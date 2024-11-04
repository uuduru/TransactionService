# TransactionService
Exercice 1
## Objectifs 

Implémenter un service TransactionServices qui permet d'ajouter une transaction et de vérifier si une transaction est valide.
La validation des transactions doit respecter les règles suivantes :

•	Le montant de la transaction ne peut pas dépasser 10 000 pour un crédit.

•	Le solde ne peut pas être inférieur à -5 000 après une transaction de débit.

•	Chaque type de transaction (Crédit/Débit) doit être implémenté comme une classe distincte, dérivant d'une classe de base commune.

•	Implémentez un mécanisme permettant d'ajouter dynamiquement de nouvelles règles de validation sans modifier le code existant (utilisation de patrons de conception recommandée).


## Implémentations des classes

•	Une classe s'appelant Transaction sera implémentée afin de stocker les informations de transactions d'un objet. Les informations seront stockées sous forme de JSON: Exemple de l'historique de transactions: 

[
  {
    "Date_of_transaction": "2024-10-21T11:03:29.5408645+02:00",
    "Type": "debit",
    "Amount_of_transaction": 900,
    "Description_of_transaction": "Rent payment"
    },
  {
    "Date_of_transaction": "2024-10-21T11:03:43.5926083+02:00",
    "Type": "credit",
    "Amount_of_transaction": 100,
    "Description_of_transaction": "FIFA 25 Reimbursement"
    }
]

•	 Une deuxième classe s'appelant TransactionServices regroupera l'ensemble des règles pour effecturer un débit / crédit.

•	 Une troisième classe s'appelant Debit sera implémentée pour effectuer des transactions de débits. La classe héritera de TransactionServices.

•	 Une quatrième classe s'appelant Credit sera implémentée pour effectuer des transactions de crédit. La classe héritera de TransactionServices.

•	 Une dernière classe s'appelant TransactionServicesExtensions sera implémentée pour ajouter de nouvelles règles à TransactionServices sans en modiier le code existant.

## Implementations projet

L'utilisateur sera amenée à choisir entre une transaction de débit / crédit. Pour chaque choix, une liste d'information(ex: la description de la transaction) sera demandée à l'utilisateur. Si l'ensemble des infos sont rentrées correctement, alors la transaction est réussie, sinon une erreur s'affiche dans la console. La gestion des erreurs dans le code est gérée par un Throw Execption avec un catch(e).

## Author

Duru Ugochukwu


