using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticasMVC.Models {
    public class HelperVimeo {
        //Metodo encargado de recuperar los videos
        public List<Video> GetVideos() {
            String[] videos = { "Rubelangel es Real" };
            String[] codigos = { "121192285" };
            List <Video> lista = new List<Video>();
            for (var i = 0; i < videos.Length; i++) {
                Video vid = new Video();
                vid.Texto = videos[i];
                vid.Codigo = codigos[i];
                lista.Add(vid);
            }
            return lista;
        }
        public String GetCodigoHTML(String codigo) {
            String html = "<iframe src='https://player.vimeo.com/video/121192285' width='640' height='360' frameborder='0' webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>";
            return html;
        }
    }
}