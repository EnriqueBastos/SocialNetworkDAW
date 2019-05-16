using SocialNetwork.Domain.Contracts;
using SocialNetwork.Domain.Dtos;
using SocialNetwork.Domain.Entities;
using System;
using System.IO;

namespace SocialNetwork.Domain.Business.PhotoBusiness
{
    public class AddPhotoBusiness : IAddPhotoBusiness
    {
        private readonly IPhotoRepository _photoRepository;

        public AddPhotoBusiness(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public void AddPhoto(PhotoDto photoDto)
        {
            
            byte[] bytesPhoto = Convert.FromBase64String(photoDto.ImageBytes); 
            _photoRepository.AddPhoto(new Photo
            {
                Title = "KIKE",
                ImageBytes = bytesPhoto,
                UpdateDateTime = photoDto.UploadDateTime,
                Likes = 0,
                Dislikes = 0
            });
        }

        public byte[] FileToByteArray(string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName,
                                           FileMode.Open,
                                           FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            return File.ReadAllBytes(fileName);
        }
    }
}
