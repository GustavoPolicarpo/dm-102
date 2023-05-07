## Projeto da disciplina DM102

Foi desenhado uma relação mínima de possíveis relações de um ecommerce. Dentro do escopo de uma loja foi considerado as entidades necessárias para o seu catálogo e no fluxo do checkout, como ilustrado abaixo. Para validação um cenário foi criado e os objetos instânciados. Por simplicidade as informações foram detalhadas em json ao serializar as classes utilizadas. ![uml](https://user-images.githubusercontent.com/22501086/236686289-ec7a92f7-b429-43e4-aad1-86377b9475a7.svg)

### Console log para o exemplo construído
```
Catalog Details
Categories:
{"Id":1,"Name":"roupa","Description":"Departamento de roupas","FatherCategoryId":null}
{"Id":2,"Name":"masculina","Description":"Roupas masculina","FatherCategoryId":1}
{"Id":3,"Name":"feminina","Description":"Roupas feminina","FatherCategoryId":1}
Brands:
{"Id":1,"Name":"gucci","Description":"Roupas Gucci"}
ProductClusters:
{"Id":1,"Name":"luxo","Description":"Roupas de luxo"}
Products:
{"Id":1,"Name":"Camiseta Gucci M Masculina","Description":null,"Price":149.9,"Stock":5,"CategoryId":2,"BrandId":1,"CollectionIds":[1]}
{"Id":2,"Name":"Camiseta Gucci P Feminina","Description":null,"Price":159.9,"Stock":3,"CategoryId":3,"BrandId":1,"CollectionIds":[1]}
Checkout Details
Orders:
{"Id":"e054f7cd-9772-4353-872f-c79f8e65b7d0","Customer":{"Name":"Policarpo","Email":"gustavo.policarpo@inatel.br","Address":"Santa Rita do Sapucai"},"Products":[{"Name":"Camiseta Gucci M Masculina","Price":149.9}],"TotalPrice":149.9,"TotalItems":1}
ActiveCarts:
{"Id":"5b6d17fe-7d56-4aad-b84a-83fe2a5467c8","Customer":{"Id":"4dfcb691-afc1-412a-9631-fdfa0a0e8627","Name":"Pagani","Email":"luis.pagani@inatel.br","Address":"Pouso Alegre"},"Products":[{"Id":2,"Name":"Camiseta Gucci P Feminina","Description":null,"Price":159.9,"Stock":3,"CategoryId":3,"BrandId":1,"CollectionIds":[1]}]}
```


## Alunos
Gustavo de Andrade Couto Policarpo

Luiz Felipe Pagani Motta 
