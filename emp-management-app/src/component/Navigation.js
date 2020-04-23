import React, { Component } from 'react';
import { NavLink } from 'react-router-dom';
import {  Nav } from 'react-bootstrap';
import Navbar from 'react-bootstrap/Navbar'

export class Navigation extends Component {
    render() {
        return (
            <>
            <Navbar bg="dark" variant="dark">
                <Navbar.Collapse id="basic-navbar-nav">
                    <Navbar.Toggle/>
                    <Nav className="mr-auto">
                        <NavLink className="d-inline p-2 bg-dark text-white"
                         to="/">Home</NavLink>
                        <NavLink className="d-inline p-2 bg-dark text-white"
                         to="/Login">____Login</NavLink>
                        <NavLink className="d-inline p-2 bg-dark text-white" 
                         to="/Registration">_____Registration</NavLink>
                         <NavLink className="d-inline p-2 bg-dark text-white" 
                         to="/EmployeeDetails">_____EmpDetails</NavLink>
                    </Nav>
                </Navbar.Collapse>
            </Navbar>
            </>
        )
    };
}

