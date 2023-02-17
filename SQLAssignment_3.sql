-- 1.      List all cities that have both Employees and Customers.
SELECT DISTINCT c.City
FROM Customers c JOIN Employees e on c.City = e.City
-- 2.      List all cities that have Customers but no Employee.
-- a.      Use sub-query
SELECT DISTINCT city
FROM Customers 
WHERE City NOT IN (SELECT DISTINCT City FROM Employees)
-- b.      Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e on c.City = e.City
WHERE e.City is NULL
-- 3.      List all products and their total order quantities throughout all orders.
SELECT ProductName, SUM(Quantity) AS TotalQuantity
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY ProductName
-- 4.      List all Customer Cities and total products ordered by that city.
SELECT c.city, SUM(Quantity) AS TotalProducts
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od on o.OrderID = od.OrderID
GROUP BY c.City
-- 5.      List all Customer Cities that have at least two customers.
-- a.      Use union
SELECT City,COUNT(1)
FROM Customers
GROUP BY City
HAVING COUNT(*) > 2 
UNION
SELECT City,COUNT(1)
FROM Customers
GROUP BY City
HAVING COUNT(*) = 2 
-- b.      Use sub-query and no union
SELECT DISTINCT City
FROM Customers c
WHERE City in (SELECT DISTINCT City FROM Customers c2 WHERE c2.City = c.City and c2.CustomerID<>c.CustomerID)
-- 6.      List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City,Count(DISTINCT ProductID) AS TotalProductKind
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od on o.OrderID = od.OrderID
GROUP BY c.City
HAVING Count(DISTINCT ProductID) >= 2
-- 7.      List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT c.ContactName
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID and c.City<>o.ShipCity
-- 8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT ProductID,AVGPrice,city
FROM
(SELECT city,avg.ProductID,AVGPrice,ROW_NUMBER() OVER(PARTITION BY temp.productID ORDER BY Count DESC) RNK
FROM
(SELECT c.city,od.ProductID,COUNT(Quantity) As Count
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od on o.OrderID = od.OrderID
GROUP BY c.City,od.ProductID) temp -- count city and quantity
JOIN
(SELECT TOP 5 p.ProductID, AVG(od.UnitPrice) as AVGPrice
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID
GROUP BY p.ProductID
ORDER BY SUM(od.Quantity) DESC) avg -- calculate most popular products and avg price
ON temp.ProductID = avg.ProductID
) Final -- combine and calculate rank
WHERE Final.rnk = 1
-- 9.      List all cities that have never ordered something but we have employees there.
-- a.      Use sub-query
SELECT DISTINCT City
FROM Employees
WHERE City NOT IN 
(SELECT DISTINCT city
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID)
-- b.      Do not use sub-query
SELECT DISTINCT e.city
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID RIGHT JOIN Employees e ON e.City = c.City
WHERE c.City IS NULL
-- 10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, 
--      and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT temp1.city
FROM
(SELECT TOP 1 city, COUNT(OrderID) as COUNT
FROM Employees e JOIN Orders o ON e.EmployeeID = o.EmployeeID
GROUP BY City
ORDER BY COUNT DESC) temp1
JOIN
(SELECT TOP 1 c.city, SUM(Quantity) AS TotalProducts
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od on o.OrderID = od.OrderID
GROUP BY c.City
ORDER BY TotalProducts DESC) temp2
ON temp1.City = temp2.City

-- 11. How do you remove the duplicates record of a table?
-- BY using CTE and window funciton row_number()
WITH CTE
AS (
    SELECT *, ROW_NUMBER() OVER(PARTITION BY CompanyName,ShipperID,Phone Order BY ShipperID) as RNK
    FROM Shippers
)
DELETE FROM CTE WHERE RNK <> 1