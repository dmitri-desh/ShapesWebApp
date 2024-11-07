CREATE TABLE Products (
    ID INT PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
);


CREATE TABLE Categories (
    ID INT PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
);

-- Создаем таблицу для связи многие ко многим
CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(ID)
);

INSERT INTO Products (ID, Name)
VALUES (1, 'Product A'), (2, 'Product B'), (3, 'Product C'), (4, 'Product D'), (5, 'Product E'),
       (6, 'Product F'), (7, 'Product G'), (8, 'Product H'), (9, 'Product I'), (10, 'Product J');


INSERT INTO Categories (ID, Name)
VALUES (1, 'Category X'), (2, 'Category Y'), (3, 'Category Z'), (4, 'Category W'), (5, 'Category V'),
       (6, 'Category U'), (7, 'Category T'), (8, 'Category S'), (9, 'Category R'), (10, 'Category Q');


INSERT INTO ProductCategories (ProductID, CategoryID)
VALUES (1, 1), (1, 2), (2, 3), (3, 1), (3, 4), (4, 5), (5, 6), (5, 7), (6, 2), (7, 8);


---------------------------------------------------------

SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductCategories pc ON p.ID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.ID
ORDER BY p.Name;
