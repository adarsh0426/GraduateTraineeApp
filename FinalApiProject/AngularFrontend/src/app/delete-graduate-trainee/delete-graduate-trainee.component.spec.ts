import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteGraduateTraineeComponent } from './delete-graduate-trainee.component';

describe('DeleteGraduateTraineeComponent', () => {
  let component: DeleteGraduateTraineeComponent;
  let fixture: ComponentFixture<DeleteGraduateTraineeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteGraduateTraineeComponent]
    });
    fixture = TestBed.createComponent(DeleteGraduateTraineeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
