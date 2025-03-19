//UC1
class Contact {
    constructor(firstName, lastName, address, city, state, zip, phone, email) {
        this.setFirstName(firstName);
        this.setLastName(lastName);
        this.setAddress(address);
        this.setCity(city);
        this.setState(state);
        this.setZip(zip);
        this.setPhone(phone);
        this.setEmail(email);
    }

    //UC2
    setFirstName(firstName) {
        let namePattern = /^[A-Z][a-zA-Z]{2,}$/;  
        if (!namePattern.test(firstName)) throw new Error("Invalid First Name");
        this.firstName = firstName;
    }

    setLastName(lastName) {
        let namePattern = /^[A-Z][a-zA-Z]{2,}$/;
        if (!namePattern.test(lastName)) throw new Error("Invalid Last Name");
        this.lastName = lastName;
    }

    setAddress(address) {
        if (address.length < 4)
            throw new Error("Address must be at least 4 characters");
        this.address = address;
    }

    setCity(city) {
        if (city.length < 4) throw new Error("City must be at least 4 characters");
        this.city = city;
    }

    setState(state) {
        if (state.length < 4)
            throw new Error("State must be at least 4 characters");
        this.state = state;
    }

    setZip(zip) {
        let zipPattern = /^\d{5}(-\d{4})?$/;
        if (!zipPattern.test(zip)) throw new Error("Invalid ZIP Code");
        this.zip = zip;
    }

    setPhone(phone) {
        let phonePattern = /^[0-9]{10}$/;
        if (!phonePattern.test(phone)) throw new Error("Invalid Phone Number");
        this.phone = phone;
    }

    setEmail(email) {
        let emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
        if (!emailPattern.test(email)) throw new Error("Invalid Email");
        this.email = email;
    }

    toString() {
        return `Name: ${this.firstName} ${this.lastName}\nAddress: ${this.address}, ${this.city}, ${this.state}, ${this.zip}\nPhone: ${this.phone}\nEmail: ${this.email}\n`;
    }
}

//UC3
class AddressBook {
    constructor() {
        this.contacts = [];
    }

    //UC3
    addContact(contact) {
        let isDuplicate =
            this.contacts.filter(
                (c) =>
                    c.firstName === contact.firstName && c.lastName === contact.lastName
            ).length > 0;

        if (isDuplicate) {  //UC7
            console.log("Duplicate contact found! Cannot add.");
            return;
        }

        this.contacts.push(contact);
        console.log("Contact added successfully!");
    }

    findContact(firstName, lastName) {
        return this.contacts.find(
            (contact) =>
                contact.firstName === firstName && contact.lastName === lastName
        );
    }

    //UC4
    editContact(firstName, lastName, updatedData) {
        let contact = this.findContact(firstName, lastName);
        if (!contact) {
            console.log("Contact not found.");
            return;
        }

        try {
            if (updatedData.address) contact.setAddress(updatedData.address);
            if (updatedData.city) contact.setCity(updatedData.city);
            if (updatedData.state) contact.setState(updatedData.state);
            if (updatedData.zip) contact.setZip(updatedData.zip);
            if (updatedData.phone) contact.setPhone(updatedData.phone);
            if (updatedData.email) contact.setEmail(updatedData.email);
            console.log("Contact updated successfully!");
        } catch (error) {
            console.error(error.message);
        }
    }

    //UC5
    deleteContact(firstName, lastName) {
        let index = this.contacts.findIndex(
            (contact) =>
                contact.firstName === firstName && contact.lastName === lastName
        );
        if (index === -1) {
            console.log("Contact not found.");
            return;
        }
        this.contacts.splice(index, 1);
        console.log("Contact deleted successfully!");
    }

    displayAllContacts() {
        if (this.contacts.length === 0) {
            console.log("Address Book is empty.");
            return;
        }
        console.log("\nAddress Book:");
        this.contacts.forEach((contact) => console.log(contact.toString()));
    }    

    //UC6
    countContacts() {
        let count = this.contacts.reduce((total) => total + 1, 0);
        console.log(`Total number of contacts: ${count}`);
        return count;
    }

    //UC8
    searchByCity(city) {
        let results = this.contacts.filter(
            (contact) => contact.city.toLowerCase() === city.toLowerCase()
        );
        if (results.length === 0) {
            console.log(`No contacts found in ${city}.`);
            return;
        }
        console.log(`Contacts in ${city}:`);
        results.map((contact) => contact.display());
    }
    //UC8
    searchByState(state) {
        let results = this.contacts.filter(
            (contact) => contact.state.toLowerCase() === state.toLowerCase()
        );
        if (results.length === 0) {
            console.log(`No contacts found in ${state}.`);
            return;
        }
        console.log(`Contacts in ${state}:`);
        results.map((contact) => contact.display());
    }

    //UC9
    viewByCity(city) {
        let results = this.contacts.filter(
            (contact) => contact.city.toLowerCase() === city.toLowerCase()
        );
        if (results.length === 0) {
            console.log(`No contacts found in ${city}.`);
            return;
        }
        console.log(`Contacts in ${city}:`);
        results.map((contact) => contact.display());
    }

    viewByState(state) {
        let results = this.contacts.filter(
            (contact) => contact.state.toLowerCase() === state.toLowerCase()
        );
        if (results.length === 0) {
            console.log(`No contacts found in ${state}.`);
            return;
        }
        console.log(`Contacts in ${state}:`);
        results.map((contact) => contact.display());
    }

    //UC10
    countByCity(city) {
        let count = this.contacts.filter(
            (contact) => contact.city.toLowerCase() === city.toLowerCase()
        ).length;
        console.log(`Number of contacts in ${city}: ${count}`);
    }

    countByState(state) {
        let count = this.contacts.filter(
            (contact) => contact.state.toLowerCase() === state.toLowerCase()
        ).length;
        console.log(`Number of contacts in ${state}: ${count}`);
    }

    //UC11
    sortContacts() {
        if (this.contacts.length === 0) {
            console.log("Address Book is empty.");
            return;
        }

        this.contacts.sort((a, b) => a.firstName.localeCompare(b.firstName));
        console.log("\nSorted Address Book:");
        this.contacts.forEach((contact) => console.log(contact.toString()));
    }

    //UC12
    sortByCity() {
        if (this.contacts.length === 0) {
            console.log("Address Book is empty.");
            return;
        }

        this.contacts.sort((a, b) => a.city.localeCompare(b.city));
        console.log("\nSorted by City:");
        this.contacts.forEach((contact) => console.log(contact.toString()));
    }

    sortByState() {
        if (this.contacts.length === 0) {
            console.log("Address Book is empty.");
            return;
        }

        this.contacts.sort((a, b) => a.state.localeCompare(b.state));
        console.log("\nSorted by State:");
        this.contacts.forEach((contact) => console.log(contact.toString()));
    }

    sortByZip() {
        if (this.contacts.length === 0) {
            console.log("Address Book is empty.");
            return;
        }

        this.contacts.sort((a, b) => a.zip.localeCompare(b.zip));
        console.log("\nSorted by ZIP Code:");
        this.contacts.forEach((contact) => console.log(contact.toString()));
    }
}

let addressBook = new AddressBook();

try {
    let contact1 = new Contact(
        "Abc",
        "Def",
        "123 Main Street",
        "New York",
        "New York",
        "10001",
        "1234567890",
        "abc.def@example.com"
    );
    addressBook.addContact(contact1);

    let contact2 = new Contact(
        "Xyz",
        "Pqr",
        "23 MG Road",
        "Mumbai",
        "Maharashtra",
        "400001",
        "9876543210",
        "Xyz.Pqr@example.in"
    );
    addressBook.addContact(contact2);
} catch (error) {
    console.error(error.message);
}

addressBook.displayAllContacts();
addressBook.countContacts();
