using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Components.Forms;
using MyApplication.Services;

namespace MyApplication.Interfaces
{
    public interface ICloudinaryService
    {
        Task<List<ImageUploadResult>> UploadPhotoAsync(IBrowserFile? file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
        
        string GetTransformedImageUrl(string publicId, int width, int height);
    }
}