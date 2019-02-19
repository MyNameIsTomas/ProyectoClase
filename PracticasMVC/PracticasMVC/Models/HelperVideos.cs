using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticasMVC.Models {
    public class HelperVideos {
        //Metodo encargado de recuperar los videos
        public List<Video> GetVideos() {
            String[] videos = { "Carl Cox", "Frank", "Pitbull", "Queen" };
            String[] codigos = { "WL8k-eeP6h0", "QsKVBQ2IjXQ", "xhfnTs0RZLs", "AyRpGcXSgvc" };
            List<Video> lista = new List<Video>();
            for (var i = 0; i < videos.Length; i++) {
                Video vid = new Video();
                vid.Texto = videos[i];
                vid.Codigo = codigos[i];
                lista.Add(vid);
            }
            return lista;
        }
        public String GetCodigoHTML(String codigo) {
            String html = "<iframe width='560' height='315' src='https://www.youtube.com/embed/" + codigo + "' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>'";
            return html;
        }
    }
}