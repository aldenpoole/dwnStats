//import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { Component, OnInit  } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { RegisteredUsers } from 'src/registeredUsers';
import { RegUsersService } from '../reg-users.service';
import { UsersTableDataSource, UsersTableItem } from './users-table-datasource';

@Component({
  selector: 'app-users-table',
  templateUrl: './users-table.component.html',
  styleUrls: ['./users-table.component.css']
})
export class UsersTableComponent implements OnInit {
  EXAMPLE_DATA: RegisteredUsers[] = [];
  displayedColumns = ['userid', 'firstname', 'lastname'];
  dataSource = new MatTableDataSource<RegisteredUsers>(this.EXAMPLE_DATA);

  constructor(private service: RegUsersService) {}

  ngOnInit() {
    this.getAllUsers();
  }

  public getAllUsers() {
    let resp=this.service.regUsers();
    resp.subscribe(report=>this.dataSource.data=report as RegisteredUsers[])
  }
}


// export class UsersTableComponent implements AfterViewInit {
//   @ViewChild(MatPaginator) paginator!: MatPaginator;
//   @ViewChild(MatSort) sort!: MatSort;
//   @ViewChild(MatTable) table!: MatTable<UsersTableItem>;
//   //dataSource: UsersTableDataSource;

//   /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
//   displayedColumns = ['userid', 'firstname', 'lastname'];

//   // constructor() {
//   //   this.dataSource = new UsersTableDataSource();
//   // }

//   constructor(private service: RegUsersService) {}

//   // ngAfterViewInit(): void {
//   //   this.dataSource.sort = this.sort;
//   //   this.dataSource.paginator = this.paginator;
//   //   this.table.dataSource = this.dataSource;
//   // }
// }
