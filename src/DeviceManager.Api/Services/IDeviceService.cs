﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DeviceManager.Api.Model;

namespace DeviceManager.Api.Services
{
    /// <summary>
    /// Device service interface
    /// </summary>
    public interface IDeviceService
    {
        /// <summary>
        /// Gets the list of devices.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        List<DeviceViewModel> GetDevices(int page, int pageSize);

        /// <summary>
        /// Gets the device by identifier.
        /// </summary>
        /// <param name="deviceId">The device identifier.</param>
        DeviceViewModel GetDeviceById(Guid deviceId);

        /// <summary>
        /// Gets the device by identifier.
        /// </summary>
        /// <param name="deviceId">The device identifier.</param>
        Task<DeviceViewModel> GetDeviceByIdAsync(Guid deviceId);

        /// <summary>
        /// Gets the device by title.
        /// </summary>
        /// <param name="deviceTitle">The device title.</param>
        /// <returns></returns>
        DeviceViewModel GetDeviceByTitle(string deviceTitle);

        /// <summary>
        /// Creates the device.
        /// </summary>
        /// <param name="deviceViewModel">The device view model.</param>
        void CreateDevice(DeviceViewModel deviceViewModel);

        /// <summary>
        /// Updates the device.
        /// </summary>
        /// <param name="deviceId">The device identifier.</param>
        /// <param name="deviceViewModel">The device view model.</param>
        void UpdateDevice(Guid deviceId, DeviceViewModel deviceViewModel);
    }
}