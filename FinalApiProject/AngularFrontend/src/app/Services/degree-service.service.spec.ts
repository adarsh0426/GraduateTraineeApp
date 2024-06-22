import { TestBed } from '@angular/core/testing';

import { DegreeServiceService } from './degree-service.service';

describe('DepartmentServiceService', () => {
  let service: DegreeServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DegreeServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
