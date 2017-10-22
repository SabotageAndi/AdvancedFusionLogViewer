using Shouldly;
using Xunit;

namespace NFileSystem.Test
{
    public class FileTests
    {
        [Fact]
        public void FullPathAndFilename_Same_as_constructor_parameter()
        {
            //ARRANGE
            var filename = @"C:\Folder\File.ending";

            //ACT
            var file = new File(filename);

            //ASSERT
            file.FullPathAndFilename.ShouldBe(filename);
        }
    }
}