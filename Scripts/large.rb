require 'fileutils'

filter = ARGV[0]

puts "Copying images to small and larges from #{filter}..."

Dir.glob(filter).each do |image|
	puts image

	name = File.basename(image, ".*")

	unless name.include? "_la"
		dir = File.dirname(image)
		large_image = name + "_la.jpg"

		FileUtils.cp(image, File.join(dir, large_image))
	end
end