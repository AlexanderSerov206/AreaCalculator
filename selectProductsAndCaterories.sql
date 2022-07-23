SELECT ProductName as Product, IsNull(CategoryName, 'None') as Category
FROM Products
LEFT JOIN ProductCategories ON Products.ProductID = ProductCategories.ProductID
LEFT JOIN Categories ON Categories.CategoryID = ProductCategories.CategoryID