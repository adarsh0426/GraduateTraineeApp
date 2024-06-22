import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateGraduateTraineComponent } from './update-graduate-traine.component';

describe('UpdateGraduateTraineComponent', () => {
  let component: UpdateGraduateTraineComponent;
  let fixture: ComponentFixture<UpdateGraduateTraineComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateGraduateTraineComponent]
    });
    fixture = TestBed.createComponent(UpdateGraduateTraineComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
