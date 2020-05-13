import React, { Component } from 'react';
import { Link } from 'react-router-dom';
//import tiger from './Components/tiger.jpg';
 export class Navigation1 extends Component{
    render(){
    return (     
  <div className="container">
    <div class="topnav">
        <Link to = "/"> Home </Link>
        <Link to = "Login">Login</Link>
        <a href ="registration">Registration</a>
        <Link to ="EmployeeDetails">EmployeeDetails</Link>
    </div>
        </div>
        
    );
    }
} 
export default Navigation1;