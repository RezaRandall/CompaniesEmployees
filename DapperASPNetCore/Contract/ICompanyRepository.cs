﻿using DapperASPNetCore.Dto;
using DapperASPNetCore.Entities;

namespace DapperASPNetCore.Contract;

public interface ICompanyRepository
{
    public Task<IEnumerable<Company>> GetCompanies();
    public Task<Company> GetCompany(int id);
    public Task<Company> CreateCompany (CompanyForCreationDto company);
    public Task UpdateCompany(int id, CompanyForUpdateDto company);
    public Task DeleteCompany(int id);
    public Task<Company> GetCompanyByEmployeeId(int id);
    public Task<Company> GetMultipleResults(int id);
    public Task<List<Company>> MultipleMapping();
}
