import networkx as nx
import matplotlib.pyplot as plt
import time

inicio = time.time()

grafo1 = nx.Graph()
grafo1.add_edges_from([
    ("A", "B"),
    ("A", "C"),
    ("B", "D"),
    ("C", "D")
])

grafo2 = nx.Graph()
grafo2.add_edges_from([
    ("1", "2"),
    ("1", "3"),
    ("2", "4"),
    ("3", "5"),
    ("5", "6")
])

print("Grafo 1:")
print("Nodos:", grafo1.nodes())
print("Aristas:", grafo1.edges())

print("\nGrafo 2:")
print("Nodos:", grafo2.nodes())
print("Aristas:", grafo2.edges())

plt.figure(1)
nx.draw(grafo1, with_labels=True)

plt.figure(2)
nx.draw(grafo2, with_labels=True)

plt.show()

fin = time.time()
print("Tiempo de ejecución:", fin - inicio)