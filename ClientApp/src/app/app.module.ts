import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

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


@NgModule({
  declarations: [
    AppComponent,
    UsersTableComponent,
    DashboardComponent,
    DataDownloadedGraphComponent,
    UserAnalyticsComponent,
    UserDownloadPiechartsComponent,
    LatestActivityComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
