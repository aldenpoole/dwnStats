import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDownloadPiechartsComponent } from './user-download-piecharts.component';

describe('UserDownloadPiechartsComponent', () => {
  let component: UserDownloadPiechartsComponent;
  let fixture: ComponentFixture<UserDownloadPiechartsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserDownloadPiechartsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserDownloadPiechartsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
