namespace AutomovilConsola;


public interface IBuilder
{
    AutomovilBuilder ConMotor(string tipoMotor);
    AutomovilBuilder ConColor(string color);
    AutomovilBuilder ConLlantas(string llantas);
    AutomovilBuilder ConSistemaSonido(string sistemaSonido);
    AutomovilBuilder ConInteriores(string interiores);
    AutomovilBuilder ConTechoSolar(bool techoSolar);
    AutomovilBuilder ConNavegacionGps(bool navegacionGps);
    AutomovilBuilder ConModelo(string modelo);
    Automovil Crear();
}   
