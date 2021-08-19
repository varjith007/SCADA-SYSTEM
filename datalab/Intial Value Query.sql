
Declare 
@SensortypeId int,
@SensorId int

Insert into SENSOR_TYPE (SensorTypeName) values ('SimulatedSensor')

Select @SensortypeId = SensorTypeId from SENSOR_TYPE where SensorTypeName = 'SimulatedSensor' 

Insert into SENSOR (SensorName, SensorTypeId) values ('TC-01' , @SensortypeId)

Select @SensorId = SensorId from SENSOR where SensorName = 'TC-01' 

Insert into STATISTICSDATA (SensorId, AverageData, MaxData, MinData) Values (@SensorId, 0 ,0 ,0) 
