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

export default class CustomerForm extends Component {
  baseUrl = 'https://localhost:44347/customers';
  constructor(props) {
    super(props);
    this.state = {
      isValid: false,
      name: '',
      age: null,
      dateOfBirth: '',
      occupation: {},
      sumOfValue: 0,
      monthlyExpensesTotal: 0,
      state: '',
      postCode: ''
    };
    this.updateValueHandler = this.updateValueHandler.bind(this);
  }

  updateValueHandler = (event) => {
    debugger
    let nam = event.target.name;
    let val = event.target.value;
    this.setState({ [nam]: val });
    console.log(this.state);
    console.log(this.state);
  }

  handleUpdateOccupation = (event) => {
    debugger
    this.setState({ occupation: event.target.value });
    console.log(this.state.occupation.rating)
  }

  handleSubmit(event) {
    event.preventDefault();
    fetch(this.baseUrl, {
      method: 'post',
      headers: { 'Content-Type': 'application/json' },
      body: {
        // "first_name": this.state.
      }
    });
  };

  getFactor(rating) {
    debugger
    if (!rating) return 0;

    switch (rating.trim()) {
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
        <form>
          <p>Name:</p>
          <input type='text' name='name' required onChange={this.updateValueHandler}></input>
          <p>Age:</p>
          <input type='number' name='age' required onChange={this.updateValueHandler}></input>
          <p>Date Of Birth:</p>
          <input type='date' name='dateOfBirth' required onChange={this.updateValueHandler}></input>

          <p>
            <select name="occupation" onChange={this.handleUpdateOccupation} value={this.state.occupation}>
              {occupationRatings.map(o => <option value={o} key={o.name}>{o.name}</option>)}
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

          <p>Total Value: {this.getFactor(this.state.occupation.rating)}</p>
        </form>

      </div>
    );
  }
}
