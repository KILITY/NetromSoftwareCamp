using MyApplication.Interfaces;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Components.Forms;


namespace MyApplication.Services
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryService(IConfiguration config)
        {
            var cloudName = config["Cloudinary:CloudName"];
            var apiKey = config["Cloudinary:ApiKey"];
            var apiSecret = config["Cloudinary:ApiSecret"];
            _cloudinary = new Cloudinary(new Account(cloudName, apiKey, apiSecret));
        }

        public async Task<List<ImageUploadResult>> UploadPhotoAsync(IBrowserFile? file)
        {
            var uploadResults = new List<ImageUploadResult>();
            var uploadResult = new ImageUploadResult();

            if (file.Size > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.Name, stream),
                    Transformation = new Transformation().Width(500).Height(500).Crop("fill").Gravity("face"),
                    Folder = "ShowTime",
                };
                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }

            uploadResults.Add(uploadResult);

            return uploadResults;
        }

        public async Task<DeletionResult> DeletePhotoAsync(string publicId)
        {
            var deletionParams = new DeletionParams(publicId);
            return await _cloudinary.DestroyAsync(deletionParams);
        }

        public string GetTransformedImageUrl(string publicId, int width, int height)
        {
            var cloudname = _cloudinary.Api.Account.Cloud;
            return $"https://res.cloudinary.com/dcaewa1m7/image/upload/w_{width},h_{height},c_scale,f_auto/{publicId}";
        }
    }
}