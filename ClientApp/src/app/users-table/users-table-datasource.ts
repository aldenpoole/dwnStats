import { RegisteredUsers } from '../models/registeredUsers';
import { catchError, finalize } from "rxjs/operators";
import { CollectionViewer, DataSource } from "@angular/cdk/collections";
import { Observable, BehaviorSubject, of } from "rxjs";
import { RegUsersService } from "../services/reg-users.service";

export class UsersTableDataSource implements DataSource<RegisteredUsers> {
    
  private usersSubject = new BehaviorSubject<RegisteredUsers[]>([]);
  private loadingSubject = new BehaviorSubject<boolean>(false);

  public loading$ = this.loadingSubject.asObservable();

  constructor(private regUsersService: RegUsersService) {}

  connect(collectionViewer: CollectionViewer): Observable<RegisteredUsers[]> {
    return this.usersSubject.asObservable();
  }

  disconnect(collectionViewer: CollectionViewer): void {
    this.usersSubject.complete();
    this.loadingSubject.complete();
  }

  loadUsers(sort = "id", order = "ASC", page = 0) {

    this.loadingSubject.next(true);

    this.regUsersService
      .findUsers(sort, order, page)
      .pipe(
        catchError(() => of([])),
        finalize(() => this.loadingSubject.next(false))
      )
      .subscribe(users => this.usersSubject.next(users));
  }
}
