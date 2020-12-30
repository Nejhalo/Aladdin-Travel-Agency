CREATE PROCEDURE insertFlight

@FlightCode nvarchar(50),
@Origin nvarchar(50),
@Destination nvarchar(50),
@FlightTime nvarchar(50),
@FlightDate nvarchar(50),
@capacity  nvarchar(50),                   
@NumberOfpassengers nvarchar(50),
@Numberofyoungchildren nvarchar(50)


AS

insert into tbt_insertFlight(FlightCode,Origin,FlightTime,FlightDate,Destination,capacity,NumberOfpassengers,Numberofyoungchildren)
values(@FlightCode,@Origin,@Destination,@capacity,@FlightDate,FlightTime,@NumberOfpassengers,@Numberofyoungchildren)