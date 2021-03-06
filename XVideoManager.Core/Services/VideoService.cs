using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using XVideoManager.Common.Extensions;
using XVideoManager.Core.Contexts;
using XVideoManager.Core.Entities;

namespace XVideoManager.Core.Services
{
    public class VideoService : IVideoService
    {
        private readonly FileDbContext _context;
        private readonly ILogger<VideoService> _logger;

        public VideoService(FileDbContext context, ILogger<VideoService> logger)
        {
            _context = context 
                ?? throw new ArgumentNullException(nameof(context));
            _logger = logger 
                ?? throw new ArgumentNullException(nameof(logger));
        }

        public void AddVideo(VideoEntity videoEntity)
        {
            if (videoEntity is null) 
                throw new ArgumentNullException(nameof(videoEntity));

            _context.Videos.Add(videoEntity);
        }

        public bool DeleteVideo(VideoEntity video)
        {
            if (video is null)
                throw new ArgumentNullException(nameof(video));

            return !(_context.Videos.Remove(video) is null);
        }

        public bool DeleteVideoByCode(string code)
            => DeleteAllVideos(x => x.Code == code);

        public bool DeleteAllVideos()
            => _context.Videos.RemoveAll(x => true);

        public bool DeleteAllVideos(Predicate<VideoEntity> match)
        {
            if (match is null) 
                throw new ArgumentNullException(nameof(match));

            return _context.Videos.RemoveAll(match);
        }

        public bool DeleteVideosByBrand(string brandName)
            => _context.Videos.RemoveAll(x => x.BrandName == brandName);

        public bool DeleteVideosByStar(string starName)
            => _context.Videos.RemoveAll(x => x.Stars?.Contains(starName) ?? false);

        public bool DeleteVideosByTags(params string[] tags)
            => _context.Videos.RemoveAll(x => false);

        public VideoEntity GetVideoByCode(string code)
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideos()
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideos(Func<VideoEntity, bool> match)
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideosByBrand(string brandName)
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideosByStar(string starName)
        {
            throw new NotImplementedException();
        }

        public IList<VideoEntity> GetVideosByTags(params string[] tags)
        {
            throw new NotImplementedException();
        }

        public void StorageVideo(VideoEntity video, string path, IList<string>? fragments, string? videoName = null, string? coverName = null)
        {
            throw new NotImplementedException();
        }

        public void UpdateVideo(VideoEntity video, VideoEntity newVideo)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVideo(Predicate<VideoEntity> match)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVideos(Func<VideoEntity, bool> match)
        {
            throw new NotImplementedException();
        }
    }
}
