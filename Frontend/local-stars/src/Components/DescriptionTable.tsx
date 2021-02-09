import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';
import Edit from '@material-ui/icons/Edit'
import { IconButton } from '@material-ui/core';

const useStyles = makeStyles({
  table: {
    maxWidth: 400,
    backgroundColor: "papayawhip",
  },
});

function DescriptionTable(props: { description: string; seller: string; phonenumber: string; editDescription?: (() => void) | null;}) {
  const classes = useStyles();

  return (
    <TableContainer className={classes.table} component={Paper}>
      <Table aria-label="description table">
        <TableBody>
            <TableRow key="Description">
              <TableCell align="right">Description:</TableCell>
              <TableCell align="left">{props.description}</TableCell>
              {props.editDescription ? 
                <IconButton aria-label="delete" onClick={props.editDescription}>
                    <Edit/>
                </IconButton>
                :
                null
              }
            </TableRow>
            <TableRow key="Seller">
              <TableCell align="right">Seller:</TableCell>
              <TableCell align="left">{props.seller}</TableCell>
            </TableRow>
            <TableRow key="Phone number">
              <TableCell align="right">Phone number:</TableCell>
              <TableCell align="left">{props.phonenumber}</TableCell>
            </TableRow>
        </TableBody>
      </Table>
    </TableContainer>
  );
}

export default DescriptionTable;