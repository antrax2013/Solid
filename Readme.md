# SOLID

L'objectif de ce repos est, à travers d'exemples de code et de katas, d'accompagner, par la pratique, des développeurs, pour qu'ils appréhendent au mieux les différents principes SOLID, leurs bénéfices et les intègrent à leurs pratiques quotidiennes.

Les cinq principes SOLID sont complémentaires et subtils. C'est dans les détails que se fait la compréhension. Il est aisé de les confondre et pas toujours simple de les isoler un part un.

Il sont avant tout une philosophie, un guide, à s'approprier, vers la résilence applicative. Ils ne sont pas un dogme.

## Solid pourquoi ?
L'idée sous jaccente des principes SOLID est de rendre résilant les entités logiciels. Elles doivent être en mesure de s'adapter aux évolutions sans qu'il soit nécessaire de les modifier. L'idée étant de limiter au maximum le nombre de modifications à faire. 

Toute modification reprénsente un risque, il est préférable qu'elle soit isolée pour circonscrire sa propagation et être plus facilement appréhender d'un point de vu congnitif.

## Les cinq principes

- Responsabilité unique : *(==S==ingle responsibility principle)*
   <br />Une entité applicative ne doit avoir qu'une seule et unique résponsabilité. Autrement dit, elle ne doit avoir qu'une seule fin. Soit elle fait partie d'une couche métier soit elle fait partie d'une couche technique elle ne doit pas faire partie des deux.
   >_Ex : J'ai d'un côté une classe `Facture`, couche métier, dont le seul objectif est de gérer les informations de facturation et de l'autre une classe purement technique permettant de générer ma facture sous forme de fichiers pdf. Si j'ai besoin de remplacer le format des fichiers par un autre format, par exemple JSON, alors, je n'aurais besoin de modifier que la couche de génération du fichier, pas la couche de gestion du contenu._

- Ouvert/fermé : *(==O==pen/closed principle)*
   <br />Une entité applicative doit être ouverte à l'extension mais fermée à la modification directe. En d'autre termes, elle doit pouvoir évoluer en étendant ses comportements pour prendre en compte de nouveaux cas plutôt que d'être modifiée.
   > _Ex: J'ai une méthode qui calcule la TVA d'une facture et un taux dépendant de la catégorie du produit : `Somme(des prix HT regroupés par categorie * Taux)`. Un nouveau taux de TVA est ajouté pour une catégorie de produits, je ne devrais pas à avoir à modifier la fonction qui calcule la TVA pour ce nouveau taux._ 
  
  
- Substitution de Liskov : *(==L==iskov substitution principle)*
   <br />Cette notion est liée à l'héritage et au polymorphisme. On parle également de covariance et de contratvariance. Toute instance de type T doit pouvoir être interchangé avec une instance de type G sous type de T et vis-versa sans que cela n'altère le comportement applicatif.
  En clair on doit pouvoir interchangé une instance d'une classe mère par une instance d'une classe fille, ou vis versa, sans altération de la cohérence de l'entité applicative.
   >_Ex: J'ai une classe `animal`, une classe `chat` et une classe `poisson-rouge`. J'ai une fonction `Nourrir` qui prend en entrée un animal. Je dois pouvoir passer une instance de la classe `chat`, `poisson-rouge` ou `animal`. Peu importe. L'objectif à la fin c'est que mon "animal" soit nourrit.__

- Ségrégation d'Interface : *(==I==nterface segregation principle)*
   <br />Composer une classe en implémentant plusieurs petites interfaces spécifiques plutôt qu'une interface plus importante dont une partie ne sera ni utilisée ni implémentée.
   >_Ex: J'implémente le concept de véhicule. J'ai une interface avec une méthode `Avancer` et une méthode `Recharger`. Si je n'implémente que des classes de type voiture, avion, bâteau... pas de soucis. Si j'ai besoin d'implémenter une classe vélo (à pédales sans moteur 😉) alors il est préférable de scinder l'interface en deux avec d'un côté une interface véhicule et de l'autre une interface véhicule à moteur._

- Inversion des dépendances : *(==D==ependency inversion principle)*
   <br />Il est préférable de dépendre d'une instance fournie à l'excution de manière dynamique que instancée de manière statique. Ce qui offre plus grande capacité d'adaption fauce aux évolutions. Tant que le contrat ne change pas, la classe n'a pas besoin d'être modifiée.  				
   >_Ex: J'ai une classe `Vegetal` avec une méthode `Photosynthetiser` qui prend en paramètre un `ObjetLumineux` capable d'`Eclairer`. Je mets en place une interface `ObjetLumineux` contenant la méthode `Eclairer`. J'implémente une classe `Soleil` et une classe `Lampe`. En fonction de critères, lors de l'exécution, l'instance de ma classe `Vegetal`, recevra un `ObjetLumineux` peu importe lequel, elle sera capable de `Photosynthetiser`. A l'avenir si je n'ai plus besoin du concept de `Lampe` et que je le remplace par un objet `Luciole` tant qu'il est un `ObjetLumineux`, je n'altère pas mon comportement applicatif. Cela étant le principce de substitution de Liskov_

## Vocabulaire
### Une entité applicative
Ce que j'appelle une entité applicative est ensemble logique et cohérent d'instructions regroupées sous forme de méthodes ou fonctions, classe, modules, bibliothèques..._

# Auteur
[![build](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/cyril-cophignon-b58b5a5b/)
