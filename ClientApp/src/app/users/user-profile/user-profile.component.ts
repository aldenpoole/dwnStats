import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})
export class UserProfileComponent implements OnInit, OnDestroy {
  id!: number;
  private sub: any;

  constructor(private route: ActivatedRoute, private service:UserService) { }

  UserDownloads: any=[];

  ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
    });

    this.getUserDownloads(this.id);
  }

  getUserDownloads(id: number){
    this.service.getUserDownloads(id).subscribe(data => {
      this.UserDownloads=data;
    });

    setTimeout(() => { 
      console.log(this.UserDownloads)
    }, 2000);

  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

}

