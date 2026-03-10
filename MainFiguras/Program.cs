
using FigurasPatterns;

IColeccion coleccionPrimaria = new SuperficieDeDibujo();
IFactoriaFiguras factoria = new FactoriaDeFiguras();

coleccionPrimaria.add(factoria.dameInstancia(TipoFiguras.Cuadrado));
coleccionPrimaria.add(factoria.dameInstancia(TipoFiguras.Circulo));
coleccionPrimaria.add(factoria.dameInstancia(TipoFiguras.Cuadrado));

Console.WriteLine("Perimetro total: "+coleccionPrimaria.damePerimetroTotal());
Console.WriteLine("Area total: " + coleccionPrimaria.dameAreaTotal());
