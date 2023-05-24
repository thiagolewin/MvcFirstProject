static public class Equipos {
    public static List<string> ListaEquipos {get;  set;}  = new List<string>();
    public static List<string> ListaMedias {get;  set;} = new List<string>{"River","Sanlorenzo","Talleres","Defensayjusticia","Estudiantes","Rosariocentral","Belgrano","Lanus","Argentinosjuniors","Boca"};
    public static List<string> ListaPantalones {get;  set;} = new List<string>{"River","Sanlorenzo","Talleres","Defensayjusticia","Estudiantes","Rosariocentral","Belgrano","Lanus","Argentinosjuniors","Boca"};
    public static List <string> ListaRemeras {get;  set;} = new List<string>{"River","Sanlorenzo","Talleres","Defensayjusticia","Estudiantes","Rosariocentral","Belgrano","Lanus","Argentinosjuniors","Boca"};
    public static Dictionary <string, Indumentaria> EquiposIndumentaria {get;  set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item) {

    bool existe = false;
    foreach(string elemento in ListaEquipos) {
        if (equipoSeleccionado == elemento) {
            existe = true;
        }
    }
    if (!existe) {
    ListaEquipos.Add(equipoSeleccionado);
    EquiposIndumentaria.Add(equipoSeleccionado, item);
    } else {
    EquiposIndumentaria[equipoSeleccionado] = item;
    }
    return true;
    }

}