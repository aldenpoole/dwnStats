import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataDownloadedGraphComponent } from './data-downloaded-graph.component';

describe('DataDownloadedGraphComponent', () => {
  let component: DataDownloadedGraphComponent;
  let fixture: ComponentFixture<DataDownloadedGraphComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataDownloadedGraphComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DataDownloadedGraphComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
