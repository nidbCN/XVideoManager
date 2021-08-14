using System;
using System.Collections.Generic;
using System.Text;
using XVideoManager.Core.Entities;

namespace XVideoManager.Core.Services
{
    public class VideoService : IVideoService
    {
        public void AddVideo(VideoEntity videoEntity)
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideoByBrand(string brandName)
        {
            throw new NotImplementedException();
        }

        public VideoEntity GetVideoByCode(string code)
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideoByStar(string starName)
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideoByTags(params string[] tags)
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideoList()
        {
            throw new NotImplementedException();
        }

        public void StorageVideo(VideoEntity video, string path, IList<string>? fragments, string? videoName = null, string? coverName = null)
        {
            throw new NotImplementedException();
        }
    }
}
