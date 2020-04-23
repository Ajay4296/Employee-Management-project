import React, { Component } from 'react';
import { Button } from 'reactstrap';
import { userLogin } from '../services/Controller';

export class Login extends Component {
    constructor(props) {
        super(props);
        this.state = {
            EmployeeId: '',
            PassWord: '',
        }
    }
    handleIdChang = (event) => {
        const EmployeeId = event.target.value;
        this.setState({
            EmployeeId: EmployeeId
        })
        console.log("EmployeeId", this.state.EmployeeId);
    }
    handlepasswordChang = (event) => {
        const PassWord = event.target.value;
        this.setState({
            PassWord: PassWord
        })
        console.log("PassWord", this.state.PassWord);
    }

    handleLogin = () => {
        userLogin(this.state.EmployeeId, this.state.PassWord)
            .then(response => {
                console.log("Add new Employee response====>", response.data);
                alert('You have successfully login');

            }).catch((err) => {
                console.log("error occured while login----------", err);
                alert('login Failed');
            });
    }

    render() {
        return (
            <div className="App">
                <div className="Login-div"><h2>Login</h2></div>
                <div className="main-Text-div">
                    <div className="Id-div">
                        <input type="text" className="input-fname-text" placeholder="Enter Employee Id" onChange={this.handleIdChang} />
                    </div>
                    <div className="Password-div">
                        <input type="password" className="input-lname-text" placeholder="Entee password" onChange={this.handlepasswordChang} />
                    </div>
                    <div className="app-button">
                        <Button onClick={this.handleLogin} color="success" block>Login</Button>
                    </div>
                </div>
            </div>
        );
    }
}
export default Login;