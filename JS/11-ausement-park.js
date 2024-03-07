/* 
Instructions
It is your job to provide and maintain parts of the IT system of an amusement park. In particular, you are responsible for the program that manages visitors and tickets.

First, you will create a new visitor in the system. Then you will provide a function for revoking a ticket. In tasks 3 and 4, you will work on the ticket tracking system that helps to prevent forgery. Lastly, you will help adapt the system to new legal requirements.

When visitors come to the amusement park for the first time, they need to register by entering their name and age in a terminal and agreeing to the terms and conditions. Of course, they also need to buy a ticket. Each ticket has an identifier like H32AZ123.

Write a function createVisitor that accepts three arguments.

The name of the visitor.
The age of the visitor.
The identifier of the ticket that the visitor bought.
The function should return an object that holds this information. The keys in the object should be called name, age and ticketId.

createVisitor('Verena Nardi', 45, 'H32AZ123');
// => { name: 'Verena Nardi', age: 45, ticketId: 'H32AZ123' }

Stuck? Reveal Hints
Opens in a modal
When people leave the amusement park, their ticket gets revoked. If they come back, they need to buy a new one. To save regular visitors some time, they only need to register once and the visitor information will be kept for subsequent visits.

That means when a visitor leaves the park, only their ticket should be invalidated but the rest of the visitor object should stay the same. Implement the function revokeTicket that accepts a visitor object, sets the ticket identifier to null and returns the object afterwards.

const visitor = {
  name: 'Verena Nardi',
  age: 45,
  ticketId: 'H32AZ123',
};

revokeTicket(visitor);
// => { name: 'Verena Nardi', age: 45, ticketId: null }

Stuck? Reveal Hints
Opens in a modal
To prevent forgery, the ticket identifiers are unique. Once a ticket is printed, its identifier is added as a key in an object in the system so it can be tracked.

Before the ticket is sold to a visitor, it is stored with the value null in the ticket tracking object. When it is sold to a visitor, the visitor's name is assigned as a value. When employees have doubts about the validity of a ticket, they need to check the status of the ticket in the system.

Implement a function ticketStatus that accepts the tracking object and a ticket identifier as arguments. It should return one of the following results.

'unknown ticket id' if the identifier was not found in the tracking object
'not sold' in case the ticket was printed but not sold
'sold to {name}' where {name} is the name of the visitor if the ticket was sold
const tickets = {
  '0H2AZ123': null,
  '23LA9T41': 'Verena Nardi',
};

ticketStatus(tickets, 'RE90VAW7');
// => 'unknown ticket id'

ticketStatus(tickets, '0H2AZ123');
// => 'not sold'

ticketStatus(tickets, '23LA9T41');
// => 'sold to Verena Nardi'

Stuck? Reveal Hints
Opens in a modal
After a while, you get feedback from the employees that they want the ticket status to be easier to understand at the first glance. They only want to see either the name of the visitor or that the ticket is invalid.

Write a function simpleTicketStatus that accepts the same arguments as ticketStatus in task 3. This function only returns one of two different results.

the name of the visitor if the ticket was sold
'invalid ticket !!!' if the ticket was not sold yet or the identifier was not found in the tracking object
const tickets = {
  '0H2AZ123': null,
  '23LA9T41': 'Verena Nardi',
};

simpleTicketStatus(tickets, '23LA9T41');
// => 'Verena Nardi'

simpleTicketStatus(tickets, '0H2AZ123');
// => 'invalid ticket !!!'

simpleTicketStatus(tickets, 'RE90VAW7');
// => 'invalid ticket !!!'

Stuck? Reveal Hints
Opens in a modal
Due to new legal requirements, newly created visitor objects now also contain detailed information on the "General Terms & Conditions" (GTC) that the user agreed to. You can see an example of the new visitor object below.

The cashiers of the amusement park now need to check whether a visitor needs to sign a new version of the GTC. For this, implement a function gtcVersion that accepts a visitor object as an argument and returns the GTC version if it is available. If the version information is not available, nothing should be returned.

const visitorNew = {
  name: 'Verena Nardi',
  age: 45,
  ticketId: 'H32AZ123',
  gtc: {
    signed: true,
    version: '2.1',
  },
};

gtcVersion(visitorNew);
// => '2.1'

const visitorOld = {
  name: 'Verena Nardi',
  age: 45,
  ticketId: 'H32AZ123',
};

gtcVersion(visitorOld);
// => undefined
*/

//Task one

function createVisitor(name, age, ticketId) {
    const Visitor = {
        name: name,
        age: age,
        ticketId: ticketId
    }

    return Visitor
}

//console.log(createVisitor('Verena Nardi', 45, 'H32AZ123'))

//Task two
const visitor = {
    name: 'Verena Nardi',
    age: 45,
    ticketId: 'H32AZ123',
  };

function revokeTicket(visitor) {
    return visitor.ticketId = null
  }

//console.log(revokeTicket(visitor))


//Task three
const tickets = {
    '0H2AZ123': null,
    '23LA9T41': 'Verena Nardi',
  };

function ticketStatus(tickets, ticketId) {
    console.log(`Verificando se ${ticketId} está no sistema`)

    for (let key in tickets) {
        console.log(`Este é o ticket verificado: ${key}`)
        if (key === ticketId) {
            console.log(`${ticketId} está no sistema`)
            if (tickets[key] === null) {
                return 'not sold'
            } else {
                return `sold to ${tickets[[key]]}`
            }
        }
    }
    return 'unknown ticket id'
  }

//console.log(ticketStatus(tickets, '0H2AZ123'))
//console.log(ticketStatus(tickets, '23LA9T41'))
  

//Task 4


function simpleTicketStatus(tickets, ticketId) {
    for (let id in tickets) {
        if (id === ticketId && tickets[id] !== null) {
            return tickets[id]
        }
    }
    return 'invalid ticket'
  }

  //console.log(simpleTicketStatus(tickets, '0H2AZ123'))


  //Task 5

  const visitorNew = {
    name: 'Verena Nardi',
    age: 45,
    ticketId: 'H32AZ123',
    gtc: {
        signed: true,
        version: '2.1',
    }  
    };

  function gtcVersion(visitor) {
   return visitor.gtc?.version
  }

  console.log(gtcVersion(visitorNew))