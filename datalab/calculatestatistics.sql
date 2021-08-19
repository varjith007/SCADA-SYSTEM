if exists ( SELECT name
from sysobjects where name = 'CalculateStatitics'
and type = 'IR')
drop trigger CalculateStatistics
go 


create trigger CalculateStatistics on MEASUREMENTDATA 
for update, insert, delete 
as 

declare
@SensorId int,
@AverageData float,
@MaxData float,
@MinData float

Select @SensorId = SensorId from inserted

select @Averagedata = AVG(MeasurementValue) from MEASUREMENTDATA where SensorId = @SensorId 
select @MinData = Min(MeasurementValue) from MEASUREMENTDATA where SensorId = @SensorId
Select @MaxData = Max(MeasurementValue) from MEASUREMENTDATA where SensorId = @SensorId

Update STATISTICSDATA set
AverageData = @Averagedata,
MinData = @MinData,
MaxData = @MaxData 
where SensorId = @SensorId

Go 
