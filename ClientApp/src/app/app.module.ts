import { NgModule } from '@angular/core';
import { BrowserModule, Title } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { UsersTableComponent } from './users-table/users-table.component';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { HttpClientModule } from '@angular/common/http';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DataDownloadedGraphComponent } from './dashboard/data-downloaded-graph/data-downloaded-graph.component';
import { UserAnalyticsComponent } from './dashboard/user-analytics/user-analytics.component';
import { UserDownloadPiechartsComponent } from './dashboard/user-download-piecharts/user-download-piecharts.component';
import { LatestActivityComponent } from './dashboard/latest-activity/latest-activity.component';
import { DashboardService } from './services/dashboard.service';
import { UsersComponent } from './users/users.component';
import { UserProfileComponent } from './users/user-profile/user-profile.component';
import { NavBarComponent } from './dashboard/nav-bar/nav-bar.component';
import { ChartsModule } from 'ng2-charts';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';


@NgModule({
  declarations: [
    AppComponent,
    UsersTableComponent,
    DashboardComponent,
    DataDownloadedGraphComponent,
    UserAnalyticsComponent,
    UserDownloadPiechartsComponent,
    LatestActivityComponent,
    UsersComponent,
    UserProfileComponent,
    NavBarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    HttpClientModule,
    ChartsModule,
    MatMenuModule,
    MatIconModule
  ],
  providers: [Title, DashboardService, UsersComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
