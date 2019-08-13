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
        public int IndexInAlbumhCollection { get; set; }

        public List<string> GetImagesByTag(string i_Tag, User i_User)
        {
            List<string> res = new List<string>();

            foreach (Album album in i_User.Albums)
            {
                if (album.Name.Contains(i_Tag))
                {
                    album.Photos.ToList().ForEach(photo => res.Add(photo.PictureNormalURL));
                }
            }
                  
                return res;
        }
    }
}