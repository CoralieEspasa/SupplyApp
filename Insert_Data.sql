 USE SupplyApplication;

INSERT INTO Suppliers([Name], SIRET, LogisticNote, QualityNote,[Address],PostalCode,[Location],Country) 
VALUES 
('La Rosee','38424795300019','6','8','5 Rue du Plat','69002','Lyon','France'),
('Vichy','84298560800012','8','7','12 AVENUE DE LA PORTE DES TERNES','75017','PARIS','France'),
('Clarins','33058975500058','9','9','32 Rue de Metz','31000','Toulouse','France'),
('L OREAL','63201210000012','9','8', '41 rue Martre', '92117','Clichy','France');
GO

USE SupplyApplication;

INSERT INTO Categories([Name])
VALUES 
('Face Care'),
('Hygiene'),
('Body Care');
GO

USE SupplyApplication;

INSERT INTO Items (ItemName, UnitPrice, DeliveryTime)
VALUES 
('Face Cream','5.02','12'),
('Normal Shampoo','7.25','7'),
('Night Face Cream','8.93','15'),
('Night Face Cream','7.90','14'),
('Mild Shampoo','5.82','12'),
('Body Cream','7.36','12'),
('Hand Cream','4.96','13'),
('Body Cream','6.99','12'),
('Body Soap','3.25','12'),
('Body Soap','5.34','15');
GO

USE SupplyApplication;

INSERT INTO PurchaseOrders(SupplierId, CreationDate)
VALUES
('3',GETDATE()),('2',GETDATE()),('1',GETDATE()),('4',GETDATE())
GO

USE SupplyApplication;

INSERT INTO OrderLines(Quantity,Remise,ItemReference,PurchaseOrderId,UnitPrice, DeliveryTime,DeliveryDate)
VALUES
('50','','1','1','7.50','7',GETDATE()),
('200','','2','1','7.50','23',GETDATE()),
('50','','3','2','7.50','7',GETDATE()),
('35','','4','2','5.50','9',GETDATE()),
('50','','5','3','7.50','15',GETDATE()),
('200','0.05','6','3','8.50','20',GETDATE()),
('300','0.07','7','4','7.50','13',GETDATE()),
('50','','8','3','8.50','14',GETDATE()),
('500','0.1','9','4','4.50','16',GETDATE()),
('250','0.15','10','1','8.50','17',GETDATE());
GO








