# ProductsAPI
Products API for application development and testing purposes.

Base URL: http://products.jeremyolu.com/api

## GET: Products
Products endpoint for retriving a list of gym/sporting related products.

Projects EndPoint: http://products.jeremyolu.com/api/products

Fields include:

- Id
- Name
- Description
- ImageUrl
- Gender
- OnSale
- Type

Response Example:

{
  "total": 3,
  "items": [
    {
      "id": 1001,
      "name": "Nike Valtec Sports Bra",
      "description": "Nike Valtec sports bra summer edition with v line straps",
      "imageUrl": "nike-valtec-sports-bra.jpg",
      "price": 32.00,
      "gender": "F",
      "onSale": false,
      "type": "Bras"
    },
    {
      "id": 1002,
      "name": "V Power Protein Shake",
      "description": "VPower chocolate protein shake for increased strength and mass",
      "imageUrl": "v-power-protein-shake.jpg",
      "price": 25.00,
      "gender": "M",
      "onSale": false,
      "type": "Supplements"
    },
    {
      "id": 1003,
      "name": "Reebok Classics White",
      "description": "White Rebook classics",
      "imageUrl": "white-reebok-classics-trainers.jpg",
      "price": 50.00,
      "gender": "M",
      "onSale": false,
      "type": "Trainers"
    }
    ]
 }

## GET: Products/:id
Product endpoint for retriving a specific product.

Example: http://products.jeremyolu.com/api/products?id=1001

## GET: Products/:name
Products endpoint for retriving results of a search based on a product's name.

Example: http://products.jeremyolu.com/api/products?name=nike
