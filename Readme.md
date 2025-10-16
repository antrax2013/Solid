# SOLID

Ce que j'appelle une entité applicative est ensemble logique et cohérent d'instructions regroupées sous forme de méthodes ou fonctions, classe, modules, bibliothèques...

- Responsabilité unique : *(==S==ingle responsibility principle)*
  Une entité applicative ne doit avoir qu'une seule et unique résponsabilité. Autrement dit, elle ne doit avoir qu'une seule fin. Soit elle est fait partie d'une couche métier soit elle fait partie d'une couche technique elle ne doit pas faire partie des deux.
  _Ex : Couche métier gestion du contenu d'une facture, couche technique génération de la facture en pdf_

- Ouvert/fermé : *(==O==pen/closed principle)*
  Une entité applicative doit être ouverte à l'extension mais fermée à la modification directe. En d'autre termes, elle doit pouvoir évoluer en étendant ses comportements pour prendre en compte de nouveaux cas plutôt que de la modifier.
  _Ex: J'ai une méthode qui calcule la TVA d'une facture : `Somme(des prix HT regroupés par taux * Taux)`. Un nouveau taux de TVA est ajouté pour une catégorie de produits, je ne devrais pas à avoir à modifier la fonction qui calcule la TVA pour ce nouveau taux._ 
  
  
- Substitution de Liskov : *(==L==iskov substitution principle)*
  Cette notion est liée à l'héritage et au polymorphisme. On parle également de covariance et de contratvariance. Toute instance de type T doit pouvoir être interchangé avec une instance de type G sous type de T et vis-versa sans que cela n'altère le comportement applicatif.
  En clair on doit pouvoir interchangé une instance d'une classe mère par une instance d'une classe fille, ou vis versa, sans altération de la cohérence de l'entité applicative.
  _Ex: J'ai une classe `animal`, une classe `chat` et une classe `poisson-rouge`. J'ai une fonction `Nourrir`. Je doit pouvoir passer une instance de la classe `chat`, `poisson-rouge` ou `animal`. Peu importe. L'objectif à la fin c'est que mon animal soit nourrit. _   