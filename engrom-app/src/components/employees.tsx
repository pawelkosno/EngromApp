import React, { FC, useEffect, useState } from 'react';
import { employeesClient, GetEmployeesQueryResult } from '../api/base';
import List from '@mui/material/List';
import { ListItem, ListItemButton, ListItemText } from '@mui/material';


const Employees: FC = () => {
    const [empoyees, setEmployees] = useState<GetEmployeesQueryResult[]>([])

    useEffect(() => {
        const getData = async () => {
            const response = await employeesClient.getApiEmployees();

            setEmployees(response.data)
        }
        getData();
    }, [])
    return (
        <>
            <List dense sx={{ width: '100%', maxWidth: 360, bgcolor: 'background.paper' }}>
                {empoyees.map((x, index) => <ListItem key={index} >
                    <ListItemText primary={`${x.firstName} ${x.lastName}`} />
                    <ListItemButton component="a" href="#simple-list">
                        <ListItemText primary="Spam" />
                    </ListItemButton>
                </ListItem>)}
            </List>
        </>
    );
}

export default Employees;