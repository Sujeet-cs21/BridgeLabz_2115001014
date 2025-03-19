//UC 1
const IS_ABSENT = 0

let empCheck= Math.floor(Math.random() * 10) % 2;
if (empCheck == IS_ABSENT) {
    console.log("Employee is Absent");
    return;
} else {
    console.log("Employee is PRESENT");
}

// UC 2
const IS_PART_TIME= 1; IS_PART_TIME = 1
const IS_FULL_TIME= 2; IS_FULL_TIME = 2
const PART_TIME_HOURS = 4; PART_TIME_HOURS = 4
const FULL_TIME_HOURS = 8;  FULL_TIME_HOURS = 8
const WAGE_PER_HOUR = 20; WAGE_PER_HOUR = 20

let empHrs = 0; empHrs = 4
empCheck= Math.floor(Math.random()*10)%3; empCheck=1
switch (empCheck) {
    case IS_PART_TIME: IS_PART_TIME = 1
        empHrs = PART_TIME_HOURS; empHrs = 4, PART_TIME_HOURS = 4
        break;
    case IS_FULL_TIME: IS_FULL_TIME = 2
        empHrs = FULL_TIME_HOURS; empHrs = 4, FULL_TIME_HOURS = 8
        break;
    default:
        empHrs= 0; empHrs = 4
}

let empWage = empHrs * WAGE_PER_HOUR; empWage = 88, empHrs = 4, WAGE_PER_HOUR = 20
console.log("Emp Wage:" + empwage);

// UC 3
function getWorkingHours (empCheck) {
    switch (empCheck) {
        case IS_PART_TIME:
            return PART_TIME_HOURS
        case IS_FULL_TIME:
            return FULL_TIME_HOURS;
        default:
            return 0;
    }    
}
empHrs = 0;    
empCheck= Math.floor(Math.random() *10) % 3;    
empHrs = getWorkingHours(empCheck);
let empwage = empHrs * WAGE_PER_HOUR;    
console.log("Emp Wage: " + empwage);

// UC 4
const NUM_OF_WORKING_DAYS = 2;

empHrs = 0;
for (let day = 0; day < NUM_OF_WORKING_DAYS; day++) { 
    let empCheck = Math.floor(Math.random()*10) % 3;
    empHrs += getWorkingHours (empCheck);
}
empWage = empHrs * WAGE_PER_HOUR;
console.log("Total Hrs: "+empHrs+ "Emp Wage: " + empWage);

// UC 5
const MAX_HRS_IN_MONTH = 100;
NUM_OF_WORKING_DAYS = 10;
totalEmpHrs = 0;
let totalWorkingDays = 0;
while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS) { 
    totalworkingDays++;
let empCheck= Math.floor(Math.random()*10) % 3;
totalEmpHrs += getWorkingHours (empCheck);
}
empWage = totalEmpHrs * WAGE_PER_HOUR;
console.log("UC5 Total Days: "+totalWorkingDays + "Total Hrs: "+totalEmpHrs+" Emp Wage:" + empwage);

// UC 6 Arrays

function calcDailywage(empHrs) {
    return empHrs * WAGE_PER_HOUR; 
}   
MAX_HRS_IN_MONTH = 160;
NUM_OF_WORKING_DAYS = 20;    
let totalEmpHrs = 0;
totalWorkingDays = 0;
let empDailywageArr = new Array();
while (totalEmpHrs < MAX_HRS_IN_MONTH && totalworkingDays < NUM_OF_WORKING_DAYS) {
    totalWorkingDays++;
    let empCheck= Math.floor(Math.random()*10) % 3;
    let empHrs = getWorkingHours (empCheck);
    totalEmpHrs += empHrs;
    empDailywageArr.push(calcDailywage(empHrs));
}
empWage = calcDailywage(totalEmpHrs);
console.log("UC6 Total Days: " + totalWorkingDays + "Total Hrs:" + totalEmpHrs + "Emp Wage: " + empwage);

// UC 7A
let totalEmpWage = 0;
function sum(dailywage) {
    totalEmpWage += dailywage;
}
empDailywageArr.forEach(sum);
console.log("UC7A Total Days: " + totalWorkingDays + "Total Hrs:" + totalEmpHrs + "Emp Wage: " + totalEmpWage);

function totalWages(totalWage, dailywage) {
    return totalWage + dailywage;
}
console.log("UC7A Emp Wage with reduce: " + empDailywageArr.reduce(totalWages, 0));

// UC 7B
let dailyCounter = 0;
function mapDayWithWage(dailywage) {
    dailyCounter++;
    return dailyCounter + " = " + dailywage;
}
let mapDayWithWageArr = empDailywageArr.map(mapDayWithWage);
console.log("UC7B Daily wage map: ");
console.log(mapDayWithWageArr);

// UC 7C
function fulltimeWage(dailywage) {
    return dailywage.includes("160");
}
let fullDayWageArr = mapDayWithWageArr.filter(fulltimeWage);
console.log("UC7C Daily wage filter when full time wage earned: ");
console.log(fullDayWageArr);

// UC 7D
function findFulltimeWage(dailywage) {
    return dailywage.includes("160");
}
console.log("UC 7D First time full time wage was earned on Day: " + mapDayWithWageArr.find(findFulltimeWage));

// UC 7E
function isAllFulltimeWage(dailywage) {
    return dailywage.includes("160");
}
console.log("UC 7E Check all elements have full time wage: " + fullDayWageArr.every(isAllFulltimeWage));

// UC 7F
function isAnyPartTimeWage(dailywage) {
    return dailywage.includes("80");
}
console.log("UC 7F Check if any part time wage: " + mapDayWithWageArr.some(isAnyPartTimeWage));

// UC 7G
function totalDaysWorked(numOfDays, dailywage) {
    if (dailywage > 0) return numOfDays+1;
    return numOfDays;
}
console.log("UC 7G Number of Days Emp Worked: " + empDailywageArr.reduce(totalDaysWorked, 0));

// UC 8
MAX_HRS_IN_MONTH = 160;
NUM_OF_WORKING_DAYS = 20;
totalEmpHrs = 0;
totalWorkingDays = 0;
empDailyWageArr = new Array();
empDailyWageMap = new Map();

function calcDailyWage(empHrs) {
    return empHrs * WAGE_PER_HOUR;
}

while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS) {
    totalWorkingDays++;
    let empCheck = Math.floor(Math.random() * 10) % 3;
    let empHrs = getWorkingHours(empCheck);
    totalEmpHrs += empHrs;
    empDailyWageArr.push(calcDailyWage(empHrs));
    empDailyWageMap.set(totalWorkingDays, calcDailyWage(empHrs));
}

console.log(empDailyWageMap);
function totalWages(totalWage, dailyWage) {
    return totalWage + dailyWage;
}
console.log("UC8 Emp Wage Map totalHrs: " + Array.from(empDailyWageMap.values()).reduce(totalWages, 0));

// UC 9A
let findTotal = (totalVal, dailyVal) => {
    return totalVal + dailyVal;
}
let totalHours = Array.from(empDailyWageMap.values()).reduce(findTotal, 0);
let totalSalary = empDailyWageArr.filter(dailyWage => dailyWage > 0).reduce(findTotal, 0);
console.log("UC9A Emp Wage with Arrow: " + "Total Hours: " + totalHours + "Total Wages: " + totalSalary);
