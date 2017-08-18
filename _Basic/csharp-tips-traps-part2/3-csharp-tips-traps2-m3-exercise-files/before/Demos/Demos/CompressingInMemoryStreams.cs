using System.IO;
using System.IO.Compression;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class CompressingInMemoryStreams
    {
        [TestMethod]
        public void Example()
        {
            const string originalString = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce dignissim vitae nulla a vehicula. Quisque ut diam suscipit, accumsan turpis ac, feugiat lorem. Nam malesuada consequat mi, vitae vulputate diam gravida quis. Aenean a neque aliquet, luctus quam vel, mattis massa. Pellentesque placerat nec sapien quis lacinia. Sed non dui vel sapien tempus laoreet ut vel ligula. Donec mattis semper erat, porttitor facilisis tortor aliquet non.
                                         Proin vitae sollicitudin lorem, fermentum convallis risus. Aliquam tellus risus, porta id interdum ac, tincidunt nec nisl. Nulla in blandit nulla, bibendum volutpat eros. Praesent tincidunt risus nec venenatis vehicula. Praesent urna odio, tempor quis justo sed, semper auctor nisi. Nulla auctor blandit mauris sit amet varius. Cras suscipit fermentum libero ac dictum. Donec vulputate eros elementum tincidunt dapibus. Fusce eget elit quam. Vestibulum ut porta ante. Mauris quis sapien vitae nulla mattis dapibus. Curabitur cursus odio sit amet tellus iaculis faucibus. Nunc sed eleifend velit, eget tincidunt orci. Curabitur ornare felis id dolor porta interdum eget a nisi. Nam ut adipiscing dui. Duis eu sapien nisl.
                                         Maecenas vulputate cursus nulla et commodo. Morbi a rhoncus tellus. Ut hendrerit quis augue ultricies eleifend. Phasellus a feugiat urna, sed mattis lorem. Sed in rutrum sem. Praesent fermentum est erat. Etiam luctus velit a nulla semper interdum.
                                         Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Quisque magna neque, lacinia sit amet consectetur non, viverra vel ligula. Phasellus accumsan quis metus accumsan aliquam. Nam posuere lorem ligula, eu mattis enim mollis non. In hac habitasse platea dictumst. Integer tristique malesuada urna at fermentum. In eget pretium massa. Donec magna nisl, suscipit ut viverra a, vehicula eu nulla. In auctor lobortis aliquam. Vestibulum adipiscing est in mi tristique, nec aliquet elit vulputate. Etiam sollicitudin malesuada semper.
                                         Sed ornare, enim ut luctus cursus, mauris ligula semper libero, sed suscipit nisi lectus quis mi. Suspendisse et auctor odio. Proin vestibulum molestie ligula, ut dapibus quam euismod id. Donec consequat purus nec tellus vulputate sagittis. Nunc eu justo in elit commodo tincidunt sit amet eu erat. Vestibulum sed lacinia magna. Duis faucibus scelerisque sapien, non vulputate augue dignissim condimentum. Fusce gravida elementum cursus. Maecenas imperdiet, nulla sagittis bibendum aliquam, velit risus pharetra erat, vel adipiscing neque magna at erat";

            var originalBytes = Encoding.ASCII.GetBytes(originalString);
            

            // compress
            var compressedBytes = Compress(originalBytes);

            var originalSize = originalBytes.Length;
            var compressedSize = compressedBytes.Length;
            var sizeDifference = originalSize - compressedSize;


            // decompress
            var decompressedBytes = Decompress(compressedBytes);
           
            var decompressedString = Encoding.ASCII.GetString(decompressedBytes);            
            var isSameString = originalString == decompressedString;
        }

    







        private byte[] Compress(byte[] originalBytes)
        {
            var compressIntoMs = new MemoryStream();

            using (var gzs = new GZipStream(compressIntoMs,
                                                                 CompressionMode.Compress))
            {
                gzs.Write(originalBytes, 0, originalBytes.Length);
            }

            // at this point, the compressIntoMs memory stream is now closed

            var compressedBytes = compressIntoMs.ToArray();

            return compressedBytes;
        }





        private byte[] Decompress(byte[] compressedBytes)
        {
            var memoryStreamOfCompressedBytes = new MemoryStream(compressedBytes);

            using (var decompressIntoMs = new MemoryStream())
            using (var gzs = new GZipStream(memoryStreamOfCompressedBytes,
                                            CompressionMode.Decompress))
            {
                gzs.CopyTo(decompressIntoMs);

                var decompressedBytes = decompressIntoMs.ToArray();

                return decompressedBytes;
            }
        }
    }  
}