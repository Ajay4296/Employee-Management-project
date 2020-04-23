const axios = require('axios');

export async function userLogin(id, password) {
    try {
        return axios.get('https://localhost:44344/api/controller/LoginEmployee?Id=' + id + '&password=' + password)
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while login Employee" + error)
        return Promise.resolve(false)
    }
}

export async function addEmployee(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.post("https://localhost:44366/api/Employee/AddEmployee", data, { headers: headers })
            .then(response => {
                return response
            })

    }
    catch (error) {
        console.log("error while adding the Employee" + error)
        return Promise.resolve(false)
    }
}

export async function deleteEmployee(id) {
    try {
        return axios.delete('https://localhost:44366/api/Employee/DeleteEmployee?id=' + id)
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while delete Employee" + error)
        return Promise.resolve(false)
    }
}

export async function updateEmployee(id, data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.put('https://localhost:44366/api/Employee/UpdateEmployee=' + id, data, { headers: headers })
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while update Employee" + error)
        return Promise.resolve(false)
    }
}

