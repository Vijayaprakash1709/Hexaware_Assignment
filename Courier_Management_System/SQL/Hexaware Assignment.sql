----------------------Task 1-------------------------
--Create Database
create database CourierManagementSystem
-- Tables -> User,Courier,Employee,Location,Payment
create table users (
    UserId int primary key identity,
    name varchar(255),
    email varchar(255) unique,
    password varchar(255),
    contactNumber varchar(20),
    address text)

create table employees (
    employeeId int primary key identity,
    name varchar(255),
    email varchar(255) unique,
    contactNumber varchar(20),
    role varchar(50),
    salary decimal(10, 2))

create table courierServices (
    serviceId int primary key identity,
    service_name varchar(100),
    cost decimal(8, 2),
    description text)

CREATE TABLE couriers (
    courierId INT PRIMARY KEY IDENTITY,
    senderName VARCHAR(255),
    senderAddress TEXT,
    receiverName VARCHAR(255),
    receiverAddress TEXT,
    weight DECIMAL(5, 2),
    status VARCHAR(50),
    tracking_number VARCHAR(20) UNIQUE,
    delivery_date DATE,
    ordered_date DATE,
    serviceId INT,
    userId INT,
    employeeId INT,
	foreign key (serviceId) references courierServices(serviceId),
    FOREIGN KEY (userId) REFERENCES users(userId),
    FOREIGN KEY (employeeId) REFERENCES employees(employeeId))

create table locations (locationId int primary key identity,
 locationName varchar(100),
  address text)

create table payments (
    paymentId int primary key identity,
    courierId int,
    locationId int,
    amount decimal(10, 2),
    paymentDate date,
    foreign key (courierId) references couriers(courierId),
    foreign key (locationId) references locations(locationId))

insert into users (name,email,password,contactnumber,address)
values ('Saran','saran@gmail.com','Saran123','12345','Salem')
insert into users (name,email,password,contactnumber,address)
values ('Thinesh','Thinesh@gmail.com','pass123','98765','attur')

insert into employees (name,email,contactnumber,role,salary)
values 
('John','john@gmail.com','9882','Employee',3500.00),
('Jayes','demo@gmail.com','97838','Manager',4000.00)

insert into courierservices (service_name,cost,description)
values 
('express delivery',25.50,'fast delivery service for urgent packages.'),
('Normal delivery',15.00,'affordable delivery service for regular packages.')

insert into couriers (sendername,senderaddress,receivername,receiveraddress,weight,status,tracking_number,delivery_date,ordered_date,serviceid,userid,employeeid,locationId)
values 
('Vijay','Attur','Jayes','Chennai',100.00,'Packed','track5',cast(getDate()as date),'2024-11-02',1,1,1,1),
('Prakash','salem','Ram','Delhi',500.00,'delivered','track6',cast(getDate() as date),'2024-11-03',2,2,2,2)

insert into locations (locationname,address)
values 
('Storage 1','Attur'),
('Storage 2','Delhi')

insert into payments (courierid,locationid,amount,paymentdate)
values 
(3,1,1000.00,'2024-11-01'),
(4,2,350.00,'2024-11-04')

-----------------------------Task 2------------------------
--List all customers:  
select * from users;

--List all orders for a specific customer:  
select * from couriers
where userId =1;

--List all couriers:  
select * from couriers;

--List all packages for a specific order:  
select * from couriers
where serviceId=2
--
select * from couriers
where userId = 1;

--List all deliveries for a specific courier: 
select * from couriers
where serviceId=1;




--List all undelivered packages:  
select * from couriers
where status != 'Delivered';

select * from couriers
where delivery_date = '2024-11-06';

--List all packages that are scheduled for delivery today:  
--------in build method to find Todays date
select * from couriers
where delivery_date = CAST(GETDATE() AS DATE);

--List all packages with a specific status:  
select * from couriers
where status = 'Delivered';

--Calculate the total number of packages for each courier.
select employeeId, count(*) as total_packages
from couriers
group by employeeId

----------datediff() method find the differece days b/w dates
--Find the average delivery time for each courier  
select courierId, 
      avg(datediff(day, ordered_date, delivery_date)) as avg_day
from couriers
group by courierId;


--List all packages with a specific weight range: 
select * from couriers
where weight between 2 and 100;

--Retrieve employees whose names contain 'John' 
select * from employees
where name like 'John%'

--Retrieve all courier records with payments greater than $50.  
select c.* 
from couriers c
join payments p on c.courierId = p.courierId
where p.amount >= 50.00

-----------------------------Task 3------------------------------
--Find the total number of couriers handled by each employee. 
select  count(*) as Number_of_couriers from couriers
group by employeeId

--Calculate the total revenue generated by each location 
alter table couriers 
add  locationId int
foreign key (locationId) references locations(locationId)

--Find the total number of couriers delivered to each location. 
select locationId,count(*) as number from couriers
group by locationId

--Find the courier with the highest average delivery time: 
select top 1 courierId,datediff(day,ordered_date,delivery_date) as diff from couriers
order by diff desc

--Find Locations with Total Payments Less Than a Certain Amount 
select * from payments 
where amount<50

--Calculate Total Payments per Location  
select sum(amount) from payments 
group by locationId

--Retrieve couriers who have received payments totaling more than $1000 in a specific location(LocationID = X): 
select s.courierId
from payments p
join 
couriers s
on p.courierId=s.courierId
join 
locations l
on p.locationId=l.locationId
where p.amount>1000 and l.locationId=1;

--Retrieve couriers who have received payments totaling more than $1000 after a certain date (PaymentDate > 'YYYY-MM-DD'):  

select c.courierId
from payments p
join 
couriers c
on p.courierId=c.courierId
where amount>1000 and paymentDate>'2022-11-02'

--Retrieve locations where the total amount received is more than $5000 before a certain date (PaymentDate > 'YYYY-MM-DD')

select l.locationName 
from locations l 
join payments p on p.locationId = l.locationId 
where p.amount > 5000 and p.paymentDate < '2024-11-05';

--------------------------------Task 4-------------------------
--Retrieve Payments with Courier Information  
select * 
from payments p
join 
couriers c
on c.courierId=p.courierId
where c.courierId=1;

--Retrieve Payments with Location Information 
select * 
from payments p
join 
locations l
on l.locationId=p.locationId
where l.locationId=1;

--Retrieve Payments with Courier and Location Information  
select * 
from payments p
join 
locations l
on l.locationId=p.locationId
join couriers c
on p.courierId =c.courierId

--List all payments with courier details  
select * 
from payments p
join 
couriers c
on c.courierId=p.courierId

--Total payments received for each courier 
select sum(amount) as Total_Sum
from payments p
join 
couriers c
on c.courierId=p.courierId
group by c.courierId

--List payments made on a specific date  
select * from payments
where paymentDate='2024-11-05'

--Get Courier Information for Each Payment
select *
from payments p
join 
couriers c
on c.courierId=p.courierId

--Get Payment Details with Location  (Repeated Question)
select * 
from payments p
join 
locations l
on l.locationId=p.locationId
where l.locationId=1;

-- Calculating Total Payments for Each Courier (Repeated Question)
select sum(amount) as Total_Sum
from payments p
join 
couriers c
on c.courierId=p.courierId
group by c.courierId

 --List Payments Within a Date Range 
 select * from payments
 where paymentDate between '2024-11-01' and '2024-11-04'

 --Retrieve a list of all users and their corresponding courier records, including cases where there are no matches on either side 
 select * from 
 users u
 full outer join 
 couriers c
 on c.userId=u.UserId

 --Retrieve a list of all couriers and their corresponding services, including cases where there are no matches on either side  

 select * from 
 courierServices u
 full outer join 
 couriers c
 on c.serviceId=u.serviceId

 --Retrieve a list of all employees and their corresponding payments, including cases where there are no matches on either side 

 select e.name,sum(p.amount) as Amount from payments p
 full outer join 
 couriers c
 on p.courierId=c.courierId
 full outer join 
 employees e
 on c.employeeId=e.employeeId
 group by e.name

 --List all users and all courier services, showing all possible combinations
 select * from
 users u
 cross join 
 couriers c
cross join
 courierServices cs

 --List all employees and all locations, showing all possible combinations:  
 select * from
 employees e
 cross join 
 locations l

 -- Retrieve a list of couriers and their corresponding sender information (if available)

 select courierId, senderName,senderAddress
 from couriers

 --Retrieve a list of couriers and their corresponding receiver information (if available):
 select courierId, receiverName,receiverAddress
 from couriers

 --Retrieve a list of couriers along with the courier service details (if available):  
 select c.courierId,cs.service_name
 from couriers c
 join courierServices cs
 on c.serviceId=cs.serviceId

 --Retrieve a list of employees and the number of couriers assigned to each employee:  
 select e.name,count(c.employeeId) as Number
 from employees e
 join 
 couriers c
 on c.employeeId=e.employeeId
 group by e.name

 -- Retrieve a list of locations and the total payment amount received at each location:  
 select l.locationName,sum(p.amount) as [Sum]
 from locations l
 join 
 payments p
 on p.locationId=l.locationId
 group by l.locationName

 --Retrieve all couriers sent by the same sender (based on SenderName).  
 select c.userId,count(c.courierID) from couriers c
 join 
 users u
 on u.userId=c.userId
 group by c.userId


 --List all employees who share the same role. 
select role,STRING_AGG(name, ' , ') as EmployeeName from employees
group by role

--Retrieve all payments made for couriers sent from the same location. 
select c.locationId,string_agg(p.amount,' , ') as Payments from
payments p
join 
couriers c
on c.courierId=p.courierId
group by c.locationId



--Retrieve all couriers sent from the same location (based on SenderAddress).  
select cast(senderAddress as varchar),string_agg(courierId,',') as CourierIds from couriers
group by cast(senderAddress as varchar)

--List employees and the number of couriers they have delivered
select employeeId, count(*)as Number_of_couriers from couriers
group by employeeId

--Find couriers that were paid an amount greater than the cost of their respective courier services 
select *
from couriers c
join 
payments p
on p.courierId=c.courierId
join 
courierServices cs
on cs.serviceId=c.serviceId
where p.amount>cs.cost

-----------------------------Task 4-----------------------
--49. Find couriers that have a weight greater than the average weight of all couriers\
select courierId
from couriers 
where weight>(select avg(weight)
from couriers)

--50. Find the names of all employees who have a salary greater than the average salary: 
select name
from employees
where salary>(select avg(salary) from employees)

--51. Find the total cost of all courier services where the cost is less than the maximum cost  
select cost from courierServices
where cost <(select max(cost) from courierServices)

--52. Find all couriers that have been paid for 
select * from payments
where courierId in (select courierId
from couriers)

--53. Find the locations where the maximum payment amount was made  
select locationName
from locations
where locationId=(select locationId
from payments
where amount=(select max(amount) from payments))

--54. Find all couriers whose weight is greater than the weight of all couriers sent by a specific sender (e.g., 'SenderName'):  
select courierId
from couriers
where weight in (select weight
from couriers where senderName='Vijay')






