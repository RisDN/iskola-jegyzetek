

const array = [5, 9, 8, 1, 4, 10, 3, -2];

// Összegzés
function sum(list) {
    let numb = 0;
    for(let i = 0; i < list.length; i++) {
        numb += list[i];
    }
    return numb;
}
console.log("1. Összegzés: " + sum(array));

// Maximum 
function getMax(list) {
    let max = 0;
    for(let i = 0; i < list.length; i++) {
        if(list[i] > max) { max = list[i]; }
    }
    return max;
}
console.log("2. Maximum: " + getMax(array));

// Eldöntés
function containsValue(list, value) {
    let i = 0;
    while(i < list.length && list[i] != value) {
        i++;
    }
    return list.length > i ? "Igen" : "Nem"
}

console.log("3. Tartalmaz e kettest? " + containsValue(array, 2) + ".")

// Megszámlálás
function count(list, value) {
    let count = 0;
    for(let i = 0; i < list.length; i++) {
        if(list[i] == value) { count++; }
    }
    return count;
}
console.log("4. Összesen " + count(array, 5) + "db ötös van benne.")

// Minimum 
function getMin(list) {
    let min = list[0];
    for(let i = 0; i < list.length; i++) {
        if(list[i] < min) { min = list[i]; }
    }
    return min;
}
console.log("5. Minimum: " + getMin(array));

// Keresés
function search(list, value) {
    let i = 0;
    while(i < list.length && list[i] != value) {
        i++;
    }
    return i + 1;
}
console.log("6. A 4-es szám a " + search(array, 4) + " indexen van.");

// Kiválasztás
function select(list, value) {
    let i = 0;
    while(i < list.length && list[i] != value) {
        i++;
    }
    return list.length > i ? i + 1: "ismeretlen";
}
console.log("7. A 12-es szám a(z) " + select(array, 12) + " indexen van.")


// Kiválogatás
function containsNegative(list) {
    let back = [];
    let i = 0;
    for(let i = 0; i < list.length; i++) {
        if(list[i] < 0) { back.push(i); }
    }
    return back;
}
console.log("8. A tömb " + containsNegative(array).length + "db negatív számot.")
