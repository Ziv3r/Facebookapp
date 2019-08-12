using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class AlbumsFeature
    {
        public List<string> GetImagesByTag(string i_Tag, User i_User)
        {
            List<string> res = new List<string>();

            foreach (Album album in i_User.Albums)
            {
                // shoud check location and description (API doesnt support)
                if (album.Name.Contains(i_Tag))
                {
                    album.Photos.ToList().ForEach(photo => res.Add(photo.PictureNormalURL));
                }
                //else
                //{
                //    res.Concat(album.Photos.ToList()
                //        .ForEach(photo => photo.Tags.ToList()
                //            .Where(tag => tag.ToString() == i_Tag))));
                //}
            }

                return res;
        }
    }
}