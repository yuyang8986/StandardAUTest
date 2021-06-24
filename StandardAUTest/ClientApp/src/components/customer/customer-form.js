import React, { Component } from 'react';


var occupationRatings = [
  {
    name: "Cleaner",
    rating: "Light Manual"
  },
  {
    name: "Doctor",
    rating: "Professional"
  },
  {
    name: "Author",
    rating: "White Collar"
  },
  {
    name: "Farmer",
    rating: "Heavy Manual"
  },
  {
    name: "Mechanic",
    rating: "Heavy Manual"
  },
  {
    name: "Florist",
    rating: "Light Manual"
  }
]

// var ratingFactors = [
//   {
//     name: "Professional",
//     factor: 1.1
//   },

//   {
//     name: "WhiteCollar",
//     factor: 1.45
//   },

//   {
//     name: "LightManual",
//     factor: 1.7
//   },

//   {
//     name: "HeavyManual",
//     factor: 2.1
//   },
// ]

export default class CustomerForm extends React.Component {
  baseUrl = 'https://localhost:44347/customers';
  constructor(props) {
    super(props);
    this.state = {
      isValid: false,
      name: '',
      age: null,
      dateOfBirth: '',
      occupation: '',
      sumOfValue: 0,
      monthlyExpensesTotal: 0,
      state: '',
      postCode: ''
    };
    this.updateValueHandler = this.updateValueHandler.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
    this.handleUpdateOccupation = this.handleUpdateOccupation.bind(this);
  }

  updateValueHandler = (event) => {
    let nam = event.target.name;
    let val = event.target.value;
    this.setState({ [nam]: val });
  }

  handleUpdateOccupation = (event) => {
    this.setState({ occupation: event.target.value });
  }

  handleSubmit(event) {
    debugger
    event.preventDefault();
    fetch(this.baseUrl, {
      method: 'post',
      headers: {
        "Access-Control-Allow-Origin": "*",
        "Access-Control-Allow-Methods": "DELETE, POST, GET, OPTIONS",
        "Access-Control-Allow-Headers": "Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With",
        'Content-Type': 'application/json'
      },
      body:
        JSON.stringify(
          {
            name: this.state.name,
            age: this.state.age,
            dateOfBirth: this.state.dateOfBirth,
            occupation: this.state.occupation,
            sumOfValue: this.state.sumOfValue,
            monthlyExpensesTotal: this.state.monthlyExpensesTotal,
            state: this.state.state,
            postCode: this.state.postCode
          })
    }).then(r => {
      console.log(r);
      alert(r);
    }).catch(error => {
      debugger
      console.log(error);
    });
  };

  // getRating(occupation) {
  //   debugger
  //   if (!occupation) return null;

  //   switch (occupation.trim()) {
  //     case 'Cleaner':
  //       return 'Light Manual';
  //     case 'Doctor':
  //       return 'Professional';
  //     case 'Author':
  //       return 'White Collar';
  //     case 'Farmer':
  //       return 'Heavy Manual';
  //     case 'Mechanic':
  //       return 'Heavy Manual';
  //     case 'Florist':
  //       return 'Light Manual';
  //     default:
  //       return null;
  //   }
  // }

  getFactor(rating) {
    if (!rating) return 0;

    switch (rating.replace(/\s/g, "")) {
      case 'Professional':
        return 1.1;
      case 'WhiteCollar':
        return 1.45;
      case 'LightManual':
        return 1.70
      case 'HeavyManual':
        return 2.1;
      default:
        return 0;
    }
  }


  render() {
    return (
      <div>
        <h1>Create Customer</h1>
        <form onSubmit={this.handleSubmit}>
          <p>Name:</p>
          <input type='text' name='name' required onChange={this.updateValueHandler}></input>
          <p>Age:</p>
          <input type='number' name='age' required onChange={this.updateValueHandler}></input>
          <p>Date Of Birth:</p>
          <input type='date' name='dateOfBirth' required onChange={this.updateValueHandler}></input>
          <p>Select Occupation</p>
          <p>
            <select name="occupation" onChange={this.handleUpdateOccupation} value={this.state.occupation.rating}>
              {occupationRatings.map(o => <option value={o.rating} key={o.name}>{o.name}</option>)}
            </select>
          </p>
          <p>Sum Of Value:</p>
          <input type='number' name='sumOfValue' min="1000" max="1000000" onChange={this.updateValueHandler}></input>
          <p>Monthly Expenses Total:</p>
          <input type='number' name='monthlyExpensesTotal' onChange={this.updateValueHandler}></input>
          <p>State:</p>
          <input type='text' name='state' onChange={this.updateValueHandler}></input>
          <p>Post code:</p>
          <input type='text' name='postCode' onChange={this.updateValueHandler}></input>

          <p>Total Value: {this.state.sumOfValue * this.getFactor(this.state.occupation)}</p>

          <button type='submit'>Submit Form</button>
        </form>

      </div>
    );
  }
}
