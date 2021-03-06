﻿using System;
using System.Diagnostics;
using System.IO;
using ForSale.OldModels;
using Xunit;

namespace ForSale.Tests
{
    public class CompressImagesTest
    {
        [Fact]
        public void Compress()
        {
            var products = Products.All();

            foreach (var product in products)
            {
                var directory = Path.Combine(@"D:\Fotos\_Sale_\", product.Id);
                var okFile = Path.Combine(directory, "ok.txt");

                if (File.Exists(okFile))
                {
                    continue;
                }

                Console.WriteLine(product.Title);

                CopyFirstImageToSmall(Path.Combine(directory, product.LocalThumbnail + ".JPG"));

                foreach (var image in Directory.GetFiles(directory))
                {
                    CopyToLarge(Path.Combine(directory, image));
                }

                File.WriteAllText(okFile, "Ok");
            }
        }

        private void CopyFirstImageToSmall(string image)
        {
            var small = Path.Combine(Path.GetDirectoryName(image), Path.GetFileNameWithoutExtension(image) + "_sm.JPG");

            if (File.Exists(small)) File.Delete(small);

            Console.WriteLine("Copying from {0} to {1}", image, small);
            File.Copy(image, small);

            Console.WriteLine("Compressing {0}", image);
            CompressImage(small, 300);
        }

        private void CopyToLarge(string image)
        {
            var large = Path.Combine(Path.GetDirectoryName(image), Path.GetFileNameWithoutExtension(image) + "_la.JPG");
            
            if (File.Exists(large)) File.Delete(large);

            Console.WriteLine("Copying from {0} to {1}", image, large);
            File.Copy(image, large);

            Console.WriteLine("Compressing {0}", image);
            CompressImage(large, 768);
        }

        private void CompressImage(string image, int size)
        { 
            var proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = "mogrify",
                    Arguments = string.Format("-resize \"{1}x{1}>\" -quality 75 {0}", image, size),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.OutputDataReceived += (sender, args) => Console.WriteLine(args.Data);
            proc.Start();

            while (proc.StandardOutput.EndOfStream == false)
            {
                Console.WriteLine(proc.StandardOutput.ReadLine());
            }
        }
    }
}
