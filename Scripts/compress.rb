require 'fileutils'

puts "Copying files to small and large..."

Dir.glob("D:/Fotos/_Sale_/Amp/**/*/*.jpg").each do |image|
	#puts image

	name = File.basename(image, ".*")

	unless name.include? "_sm"
		dir = File.dirname(image)
		small_image = name + "_sm.jpg"
		#large_image = File.basename(image, ".*") + "_la.jpg"

		FileUtils.cp(image, File.join(dir, small_image))
		#FileUtils.cp(image, File.join(dir, large_image))
	end
end

puts "Resizing into small images..."

Dir.glob("D:/Fotos/_Sale_/**/*/*_sm.jpg").each do |image|
	exec("C:\\Program Files\\ImageMagick-6.9.0-Q16\\mogrify.exe -resize \"300x300>\" -quality 75 #{image}")
end

#puts "Resizing into large images..."

#Dir.glob("D:/Fotos/_Sale_/**/*/*_la.jpg").each do |image|
#	exec("mogrify -resize \"768x768>\" -quality 75 #{image}")
#end