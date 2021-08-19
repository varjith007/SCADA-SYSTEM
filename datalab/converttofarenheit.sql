 IF EXISTS (SELECT name
 from sysobjects
 WHERE name = 'ConvertToFarenheit'
 AND type = 'P')
 DROP TRIGGER ConvertToFarenheit
 GO 

 create trigger ConvertToFarenheit On MEASUREMENTDATA 
 for update, insert 
 as 

 declare 
 @MeasurementId int, 
 @MeasurementValue float, 
 @FarenheitValue float 

 select @MeasurementId = MeasurementDataId from inserted
 select @MeasurementValue = MeasurementValue from inserted

Set @FarenheitValue = (@MeasurementValue*9)/5 + 32

update MEASUREMENTDATA set FarenheitValue = @FarenheitValue where MeasurementDataId = @MeasurementId 

GO 
