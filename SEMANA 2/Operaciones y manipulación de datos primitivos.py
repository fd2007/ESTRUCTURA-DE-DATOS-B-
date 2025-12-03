import math
# SEMANA 2

#  CLASE CIRCULO

# La clase Circulo encapsula el valor del radio y contiene métodos
# para calcular el área y el perímetro (circunferencia).
class Circulo:

    # Constructor que inicializa el atributo radio
    def __init__(self, radio):
        self.radio = radio

    # CalcularArea devuelve el área del círculo
    def calcular_area(self):
        return math.pi * self.radio * self.radio

    # CalcularPerimetro devuelve la circunferencia del círculo
    def calcular_perimetro(self):
        return 2 * math.pi * self.radio


#  CLASE RECTANGULO

# La clase Rectangulo encapsula ancho y alto.
# Permite calcular el área y el perímetro.
class Rectangulo:

    # Constructor que inicializa los atributos
    def __init__(self, ancho, alto):
        self.ancho = ancho
        self.alto = alto

    # Devuelve el área del rectángulo
    def calcular_area(self):
        return self.ancho * self.alto

    # Devuelve el perímetro del rectángulo
    def calcular_perimetro(self):
        return 2 * (self.ancho + self.alto)


#  PRUEBAS

# Crear un círculo de radio 5
circulo = Circulo(5)
print("CÍRCULO")
print("Área:", circulo.calcular_area())
print("Perímetro:", circulo.calcular_perimetro())

# Crear un rectángulo de 4x6
rectangulo = Rectangulo(4, 6)
print("\nRECTÁNGULO")
print("Área:", rectangulo.calcular_area())
print("Perímetro:", rectangulo.calcular_perimetro())
