import React from 'react';
import './App.css';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { Login } from './pages/Login';
import { Registration } from './pages/Registration';
import { Navigation } from './component/Navigation';
import { EmployeeDetails } from './pages/EmployeeDetails';
import {UpdateEmployee} from './pages/UpdateEmplyee';
import Home from './pages/Home';

function App() {
  return (
    <BrowserRouter>
      <div>
        <h1 className="App">Employee Management Portal</h1>
        <Navigation/>
        <Switch>
        <Route path='/' component={Home} exact />
          <Route path='/Registration' component={Registration} />
          <Route path='/Login' component={Login} />
          <Route path='/EmployeeDetails' component={EmployeeDetails} />
          <Route path='/UpdareEmployee' component={UpdateEmployee} />
        </Switch>
      </div>
    </BrowserRouter>
  );
}
export default App;

