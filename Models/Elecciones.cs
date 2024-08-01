public class Eleccion{
    //Propiedades
    public string Hotel {get; private set;}
    public string Restaurante {get; private set;}
    public string Entretenimiento {get; private set;}

    
    //Constructor
    public Eleccion (){ }
    public Eleccion (string hotel, string restaurante, string entretenimiento){
        Hotel = hotel;
        Restaurante = restaurante;
        Entretenimiento = entretenimiento;
    }
}
