

using FileStorage.Infrastructure.SignatureVerify.FileTypes;

namespace FileStorage.Infrastructure.SignatureVerify
{
    public interface IFileTypeVerifier
    {
        FileTypeVerifyResult Verify(byte[] file, string extension);
    }
}