import { registerLocaleData } from '@angular/common';
import { Component, OnInit, AfterViewInit,ViewChild  } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { tap } from 'rxjs/operators';
import { RegisteredUsers } from '../models/registeredUsers';
import { RegUsersService } from '../services/reg-users.service';
import { UsersTableDataSource} from './users-table-datasource';

@Component({
  selector: 'app-users-table',
  templateUrl: './users-table.component.html',
  styleUrls: ['./users-table.component.css']
})
export class UsersTableComponent implements OnInit, AfterViewInit {

  displayedColumns: string[] = ["id", "firstName", "lastName", "userName"];
  dataSource!: UsersTableDataSource;
  data: RegisteredUsers[] = [];

  usersCount = 10;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  //@ViewChild(MatSort) sort: MatSort;

  constructor(private regUsersService: RegUsersService) {}

  ngOnInit() {
    this.dataSource = new UsersTableDataSource(this.regUsersService);
    this.dataSource.loadUsers();
  }

  ngAfterViewInit() {
    this.paginator.page.pipe(tap(() => this.loadUsersPage())).subscribe();
  }

  loadUsersPage() {
    this.dataSource.loadUsers("id", "ASC", this.paginator.pageIndex+1);
  }
}