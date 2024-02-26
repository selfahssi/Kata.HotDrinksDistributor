# Kata.HotDrinksDistributor

## Méthodo
Pour ce mini projet, j'ai organisé mon projet en si'inspirant de l'architecure en Onion comme suit :
* Une bibliothèque de classes DataAccess qui gère l'accès aux données via Sqlite en utilisant EntityFramework Core. Ce projet dépend du projet Domain

* Une bibliothèque de classes Domain qui expose les service Recette et Ingredient. Elle exposent notamment les Models ainsi que les interfaces et les ports
  * A Noter : En temps normal, j'aurais séparé les modèles de données (sur lequelles se base le DataAccess) des modèles Business, et les mapper ensuite en utilisant des extensions ou des outils comme automapper;
    mais pour aller vite, j'utilise des données uniques pour l'accès au données, la logique est l'affichage. 

* Une application Razor pages pour l'affichage! J'ai gardé les élements graphiques du template Microsoft et j'ai réecrit la page Index en injectant le services nécessaires
  * Pour l'affichage, je propose une dropdownlist avec les différentes recettes, et j'affiche par la suite les prix des boissons (j'aurai pu également afficher le détail de la recette)

 
## Stack
* C# / ASP.Net Core 6 / Razor
* EntityFramework Core / Sqlite


## Preview

| Avant choix                                       | Après choix                                       |
| --------------------------------------------------| ------------------------------------------------- |
| ![image](https://github.com/selfahssi/Kata.HotDrinksDistributor/assets/17069178/80a3ab69-d577-4b37-82fd-b1508b29d639)  | ![image](https://github.com/selfahssi/Kata.HotDrinksDistributor/assets/17069178/84db27f6-8d00-45e4-9dcb-6702c4a22480)
 |


  
